namespace TowerDeffence.Engine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Threading;
    using System.Threading.Tasks;

    using GameObjects;
    using Interfaces;
    using Helpers;
    using Helpers.Player;
    using Helpers.Enemies;

    public class Ngin
    {
        private const int TimeInterval = 300;
        private static readonly Position GroundSpawnPosition = new Position(10, 1);
        private static readonly Position AirSpawnPosition = new Position(22, 1);
        private static readonly Position DefaultPosition = new Position(0, 0);

        private int level = 1;

        public Ngin(IPlayer player, IUserInputHandler userInputController, GamePlayfield gamePlayfield, InteractionManager interactionManager, ICollisionHandler collisionHandler, IRenderer renderer)
        {
            Player = player;
            UserInputController = userInputController;
            GamePlayfield = gamePlayfield;
            InteractionManager = interactionManager;
            CollisionHandler = collisionHandler;
            Renderer = renderer;
            RangeCollisionHandler = new RangeCollisionHandler();
            InGame = false;

            BattleUnits = new List<object>();
            TurretUnits = new List<object>();
            PlayerTurrets = new List<ITower>();
        }

        public bool InGame { get; private set; }

        public IPlayer Player { get; private set; }

        public IUserInputHandler UserInputController { get; private set; }

        public GamePlayfield GamePlayfield { get; private set; }

        public InteractionManager InteractionManager { get; set; }

        public ICollisionHandler CollisionHandler { get; private set; }

        public IList<object> BattleUnits { get; set; }

        public IList<object> TurretUnits { get; set; }

        public IList<ITower> PlayerTurrets { get; private set; }

        public void ShowGameMenu()
        {
            Renderer.DrawGameMenu();
        }

        public void InitGame()
        {
            TurretUnits = InitTurrets();
        }

        public IList<object> InitEnemies(int level)
        {
            var enemiesList = new List<object>();
            var enemyFactory = new EnemyUnitFactory();
            var loadedData = LoadManager.Instance.LoadEnemyDataXml(level);
            foreach (var enemyData in loadedData)
            {
                UnitSize size;
                if (!Enum.TryParse(enemyData.Size, true, out size))
                {
                    throw new InvalidEnumArgumentException(@"Unit size is invalid.");
                }

                if (enemyData.Type.ToLower().Equals("ground"))
                {
                    var groundUnits = enemyFactory.CreateEnemyGroundUnitByCount(size, enemyData.Health, enemyData.Bounty, enemyData.Speed, GroundSpawnPosition, enemyData.Count);
                    enemiesList.AddRange(groundUnits);
                }
                else if (enemyData.Type.ToLower().Equals("air"))
                {
                    var airUnits = enemyFactory.CreateEnemyAirUnitByCount(size, enemyData.Health, enemyData.Bounty, enemyData.Speed, AirSpawnPosition, enemyData.Count);
                    enemiesList.AddRange(airUnits);
                }
            }

            return enemiesList;
        }

        public IList<object> InitTurrets()
        {
            var turretsList = new List<object>();
            var turretFactory = new PlayerUnitFactory();
            var loadedTurretData = LoadManager.Instance.LoadTurretDataXml();

            foreach (var turretData in loadedTurretData)
            {
                if (turretData.Type.ToLower().Equals("air"))
                {
                    var airTower = turretFactory.CreatePlayerAirUnit(turretData.Price, DefaultPosition, turretData.Range, turretData.Damage, turretData.FireRate);
                    turretsList.Add(airTower);
                }
                else if (turretData.Type.ToLower().Equals("ground"))
                {
                    var groundTower = turretFactory.CreatePlayerGroundUnit(turretData.Price, DefaultPosition, turretData.Range, turretData.Damage, turretData.FireRate);
                    turretsList.Add(groundTower);
                }
            }
            return turretsList;
        }

        public IRenderer Renderer { get; set; }

        public RangeCollisionHandler RangeCollisionHandler { get; set; }

        private void InitPlayerTurrets()
        {
            var playerFactory = new PlayerUnitFactory();

            PlayerTurrets.Add(playerFactory.CreatePlayerGroundUnit(100, new Position(11, 5), 10, 25, 1));
            PlayerTurrets.Add(playerFactory.CreatePlayerGroundUnit(100, new Position(11, 10), 10, 25, 1));
            PlayerTurrets.Add(playerFactory.CreatePlayerGroundUnit(100, new Position(9, 15), 10, 25, 1));
            PlayerTurrets.Add(playerFactory.CreatePlayerAirUnit(100, new Position(20, 17), 20, 25, 1));
        }

        private void InitLevel(int level)
        {
            BattleUnits = InitEnemies(level);
            InitEnemies(level);
            Renderer.DrawGameWindow();
        }

        public void PlayLevel(int level)
        {
            InGame = true;
            InitLevel(level);
            Renderer.DrawGameInfo();
            InitPlayerTurrets();

            Task.Run(() => NextFrame());
            Task.Run(() => ReadCommand());
        }
        private void NextFrame()
        {
            while (true)
            {
                Renderer.DrawEnemiesInfo(BattleUnits);
                Renderer.DrawMap(GamePlayfield.Map, 1, 1);
                int enemyCount = 0;
                foreach (object battleUnit in BattleUnits)
                {
                    var enemy = (IEnemyUnit)battleUnit;
                    ((IDrawable)enemy).Draw();
                    var nextPosition = InteractionManager.GetNextPosition(GamePlayfield.Map, enemy);
                    ((IMoveable)enemy).Move(nextPosition);
                    Console.SetCursorPosition((int)enemy.Position.X, (int)enemy.Position.Y);
                    Console.Write(' ');
                    ((IDrawable)enemy).Draw();
                    enemyCount += 1;
                }
                foreach (var playerTurret in PlayerTurrets)
                {
                    ((IDrawable)playerTurret).Draw();

                    for (int i = 0; i < BattleUnits.Count; i++)
                    {
                        var isInRange = RangeCollisionHandler.IsInRange(playerTurret, (IEnemyUnit)BattleUnits[i]);
                        if (isInRange)
                        {
                            ((IEnemyUnit)BattleUnits[i]).Health -= (int)playerTurret.Damage;
                            if (((IEnemyUnit)BattleUnits[i]).Health <= 0)
                            {
                                BattleUnits.RemoveAt(i);
                            }
                        }
                    }
                }

                if (BattleUnits.Count == 0)
                {
                    level += 1;
                    InitEnemies(level);
                    PlayLevel(level);
                }
                Thread.Sleep(TimeInterval);
            }
        }

        public void SetPlayerName()
        {
            const string nameQuestion = "Enter your name: ";

            int left = ConsoleSettings.MaxWidth / 2 - nameQuestion.Length;
            int top = ConsoleSettings.MaxHeight / 3;
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(nameQuestion);
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();
            Player.Name = name;
            Console.Clear();
        }

        public void ReadCommand(int inner = 0)
        {
            string command = UserInputController.ReadKey().ToLower();

            Console.Clear();

            if (!InGame)
            {
                if (command.Equals("1"))
                {
                    SetPlayerName();
                    PlayLevel(1);
                }
                else if (command.Equals("2"))
                {
                    Renderer.DrawAuthors();
                    ReadCommand();
                }
                else if (command.Equals("3"))
                {
                    Environment.Exit(0);
                }
                else if (command.Equals("b"))
                {
                    Renderer.DrawGameMenu();
                    ReadCommand();
                }
            }
            else
            {
                if (command.Equals("t"))
                {

                }
            }
        }
    }
}

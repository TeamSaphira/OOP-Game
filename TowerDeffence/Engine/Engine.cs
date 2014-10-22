namespace TowerDeffence.Engine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using GameObjects;
    using Interfaces;
    using Helpers;
    using Helpers.Player;
    using Helpers.Enemies;

    public class Engine
    {
        private const int TimeInterval = 300;
        private static readonly Position GroundSpawnPosition = new Position(100, -25);
        private static readonly Position AirSpawnPosition = new Position(-25, 300);
        private static readonly Position DefaultPosition = new Position(0,0);

        private static Timer timer;

        public Engine(IPlayer player, IUserInputHandler userInputController, GamePlayfield gamePlayfield, InteractionManager interactionManager, ICollisionHandler collisionHandler)
        {
            Player = player;
            UserInputController = userInputController;
            GamePlayfield = gamePlayfield;
            InteractionManager = interactionManager;
            CollisionHandler = collisionHandler;

            this.BattleUnits = new List<object>();
            this.TurretUnits = new List<object>();

            timer = new Timer() {Interval = TimeInterval};
        }

        public IPlayer Player { get; private set; }

        public IUserInputHandler UserInputController { get; private set; }

        public GamePlayfield GamePlayfield { get; private set; }

        public InteractionManager InteractionManager { get; set; }

        public ICollisionHandler CollisionHandler { get; private set; }

        private IList<object> BattleUnits { get; set; }

        private IList<object> TurretUnits { get; set; }

        public void InitGame()
        {
            this.TurretUnits = InitTurrets();
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
                    enemiesList.AddRange(groundUnits.Cast<object>());
                }
                else if (enemyData.Type.ToLower().Equals("air"))
                {
                    var airUnits = enemyFactory.CreateEnemyAirUnitByCount(size, enemyData.Health, enemyData.Bounty, enemyData.Speed, AirSpawnPosition, enemyData.Count);
                    enemiesList.AddRange(airUnits.Cast<object>());
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

        public void InitLevel(int level)
        {
            this.BattleUnits = InitEnemies(level);   
        }

        public void PlayLevel(int level, Form form)
        {
            InitLevel(level);
            form.Controls.Clear();

            timer.Tick += (sender, args) => NextFrame(form);
            timer.Start();
        }
        private void NextFrame(Form form)
        {
            form.Controls.Clear();
            var l = new Label() {Location = new Point(100,new Random().Next(0, 800))};
            form.Controls.Add(l);

            foreach (var battleUnit in BattleUnits)
            {
                var pos = InteractionManager.GetNextPosition(GamePlayfield.Map, battleUnit);
                
            }
        }
    }
}

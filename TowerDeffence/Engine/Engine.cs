using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TowerDeffence.Helpers;

namespace TowerDeffence.Engine
{
    using GameObjects;
    using Interfaces;

    public class Engine
    {
        public Engine(IPlayer player, IUserInputHandler userInputController, GamePlayfield gamePlayfield, IInteractionManager interactionManager, ICollisionHandler collisionHandler, IRenderer renderer)
        {
            Player = player;
            UserInputController = userInputController;
            GamePlayfield = gamePlayfield;
            InteractionManager = interactionManager;
            CollisionHandler = collisionHandler;
            Renderer = renderer;

            this.BattleUnits = new Collection<IBattleUnit>();
        }

        public IPlayer Player { get; private set; }

        public IUserInputHandler UserInputController { get; private set; }

        public GamePlayfield GamePlayfield { get; private set; }

        public IInteractionManager InteractionManager { get; set; }

        public ICollisionHandler CollisionHandler { get; private set; }

        public IRenderer Renderer { get; private set; }

        private ICollection<IBattleUnit> BattleUnits { get; set; }

        public void InitGame()
        {
            
        }

        public IList<IEnumerable<object>> InitLevel(int level)
        {
            var levelList = new List<IEnumerable<object>>();

            var loader = LoadManager.Instance;
            var enemyData = loader.LoadEnemyDataXml(level);

            var enemyDataLoaded = new List<object>();
            foreach (var data in enemyData)
            {
                enemyDataLoaded.Add(data);
            }

            levelList.Add(enemyDataLoaded);

            return levelList;
        }

        public IList<IEnemyUnit> CreateEnemiesCollection(IList<IEnumerable<object>> data)
        {
            var enemies = new List<IEnemyUnit>();
            var enemyFactory = new EnemyUnitFactory();
            foreach (var d in data)
            {
                foreach (var enemy in d)
                {
                    var enemyData = enemy as EnemyData;
                    if (enemyData != null)
                    {

                        var currentEnemy = enemyData;
                        IEnemyUnit battleUnit = null;

                        UnitSize size;
                        if (!Enum.TryParse(currentEnemy.Size, true, out size))
                        {
                            throw new FormatException();
                        }

                        if (currentEnemy.Type.ToLower() == "air")
                        {
                            battleUnit = enemyFactory.CreateEnemyAirUnit(size, currentEnemy.Health, currentEnemy.Bounty, currentEnemy.Speed, new Position(0, 0));
                        }
                        else if (currentEnemy.Type.ToLower() == "ground")
                        {
                            battleUnit = enemyFactory.CreateEnemyGroundUnit(size, currentEnemy.Health, currentEnemy.Bounty, currentEnemy.Speed, new Position(0, 0));
                        }
                        enemies.Add(battleUnit);
                    }
                }
            }

            return enemies;
        }

        public void PlayLevel(int level, Form form)
        {
            form.Controls.Clear();
            var data = InitLevel(level);
            var enemies = CreateEnemiesCollection(data);

            foreach (var enemyUnit in enemies)
            {
                MessageBox.Show(enemyUnit.ToString());
            }
        }
    }
}

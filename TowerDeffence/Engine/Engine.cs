namespace TowerDeffence.Engine
{
    using System;

    using Helpers;
    using GameObjects;
    using Interfaces;

    public class Engine
    {
        public Engine(IPlayer player, IUserInputHandler userInputController, GamePlayfield gamePlayfield, BattleUnitDecorator battleUnitDecorator, IInteractionManager interactionManager, ICollisionHandler collisionHandler, IEnemyUnitFactory enemyUnitFactory, IRenderer renderer)
        {
            Player = player;
            UserInputController = userInputController;
            GamePlayfield = gamePlayfield;
            BattleUnitDecorator = battleUnitDecorator;
            InteractionManager = interactionManager;
            CollisionHandler = collisionHandler;
            EnemyUnitFactory = enemyUnitFactory;
            Renderer = renderer;
        }

        public IPlayer Player { get; private set; }

        public IUserInputHandler UserInputController { get; private set; }

        public GamePlayfield GamePlayfield { get; private set; }

        public BattleUnitDecorator BattleUnitDecorator { get; private set; }

        public IInteractionManager InteractionManager { get; set; }

        public ICollisionHandler CollisionHandler { get; private set; }

        public IEnemyUnitFactory EnemyUnitFactory { get; private set; }

        public IRenderer Renderer { get; private set; }

        public void InitGame()
        {
            // load game global files
            throw new NotImplementedException();
        }

        public void InitLevel(int level)
        {
            //  load data
            // init data
        }

        public void Run()
        {
            InitGame();
            InteractionManager.ShowGameMenu();
            // gameMenu start onclick LoadLevel(1)
        }
    }
}

﻿namespace TowerDeffence.Engine
{
    using System;

    using Helpers;
    using GameObjects;
    using Interfaces;
    using Graphics;

    public class Engine
    {
<<<<<<< HEAD
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

<<<<<<< HEAD
        public IInteractionManager InteractionManager { get; set; }

        public ICollisionHandler CollisionHandler { get; private set; }

        public IEnemyUnitFactory EnemyUnitFactory { get; private set; }

        public IRenderer Renderer { get; private set; }

        public void InitGame()
=======
        public TowerDeffence.Interfaces.IEnemyUnitFactory EnemyUnitFactory
>>>>>>> origin/UserInput
        {
            // load game global files
            throw new NotImplementedException();
        }

        public void InitLevel(int level)
        {
            //  load data
            // init data
        }
    }
}

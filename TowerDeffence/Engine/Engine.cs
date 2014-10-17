namespace TowerDeffence.Engine
{
    using Helpers;
    using GameObjects;
    using Interfaces;
    using Graphics;

    public class Engine
    {
        private IUserInputHandler controller;
        public Engine(IUserInputHandler controller)
        {
            this.controller = controller;
        }

        public IPlayer Player
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                
            }
        }

        public GamePlayfield GamePlayfield
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public BattleUnitDecorator BattleUnitDecorator
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IInteractionManager InteractionManager
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TowerDeffence.Interfaces.ICollisionHandler CollisionHandler
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TowerDeffence.Interfaces.IEnemyUnitFactory EnemyUnitFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TowerDeffence.Interfaces.IRenderer Renderer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}

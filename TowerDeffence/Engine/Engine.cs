using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDeffense.Engine
{
    using Helpers;
    using GameObjects;
    using Interfaces;

    public class Engine
    {


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

        public IUserInputHandler UserInputController
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IRenderer Renderer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Timer Timer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public EnemyUnitFactory EnemyUnitFactory
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

        public CollisionHandler CollisionHandler
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

        public InteractionManager InteractionManager
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

using System.Collections.Generic;
using System.Collections.ObjectModel;

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

        public void InitLevel(int level)
        {
            // get data from loader
            // init data
        }

        public void LoadLevel(int level)
        {
            InitLevel(1);
            // do the god damn magic
        }
    }
}

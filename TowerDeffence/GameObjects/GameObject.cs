﻿namespace TowerDeffence.GameObjects
{
    using Helpers;


    
        public abstract class GameObject
        {

            protected GameObject()
            {
                this.Position = new Position(0, 0);
            }

            protected GameObject(Position position)
            {
                this.Position = position;
            }

            public Position Position { get; protected set; }
        }
      
}

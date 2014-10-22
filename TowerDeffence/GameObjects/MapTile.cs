<<<<<<< HEAD
﻿using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    public abstract class MapTile : GameObject
    {
        protected MapTile(Position position)
            : base(position)
        {
            
        }
    }
}
=======
﻿namespace TowerDeffence.GameObjects
{
    using System.Drawing;
    using System.Windows.Forms;
    using TowerDeffence.Helpers;
    public abstract class MapTile : GameObject
    {
        public Color MyProperty { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Position Position { get; set; }
    }
}
>>>>>>> GameMap

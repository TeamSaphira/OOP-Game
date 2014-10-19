namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using GameObjects;
    using Helpers;

    public abstract class BattleUnit : GameObject, IBattleUnit, IDrawable
    {
        public event UnitOnDeathHandler OnDeath;

<<<<<<< HEAD
        public UnitSize Size
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public static int Image
        {
            // todo sprite  load image in static constructor
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public abstract void Draw();
=======
        protected BattleUnit(UnitSize size, int health, int price, Position position)
            : base(position)
        {
            Size = size;
            Health = health;
            Price = price;
        }

        public UnitSize Size { get; private set; }

        public abstract void Draw();


        public int Health { get; private set; }

        public int Price { get; private set; }
>>>>>>> enemyUnits
    }
}

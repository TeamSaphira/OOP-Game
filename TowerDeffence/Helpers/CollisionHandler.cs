namespace TowerDeffence.Helpers
{
    using System;

    using Interfaces;

    public abstract class CollisionHandler : ICollisionHandler
    {
        public event EventHandler OnCollide;
    }
}

namespace TowerDeffence.Interfaces
{
    using System;

    public interface ICollisionHandler
    {

        event EventHandler OnCollide;
        // todo create delegate for handling
    }
}

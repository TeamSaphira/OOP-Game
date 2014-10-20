namespace TowerDeffence.Interfaces
{
    using System;
    public interface IUserInputHandler
    {
        event EventHandler PressedZ;
        event EventHandler PressedX;
        event EventHandler PressedC;
        event EventHandler PressedV;
        event EventHandler OnLeftMouseClick;
        event EventHandler OnDoubleMouseClick;
        event EventHandler OnRightMouseClick;
    }
}

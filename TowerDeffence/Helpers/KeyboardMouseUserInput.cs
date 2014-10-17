namespace TowerDeffence.Helpers
{
    using System;
    using System.Windows.Forms;
    using TowerDeffence.Interfaces;
    public class KeyboardMouseUserInput : IUserInputHandler
    {
        public event EventHandler PressedZ;

        public event EventHandler PressedX;

        public event EventHandler PressedC;

        public event EventHandler PressedV;

        public event EventHandler OnLeftMouseClick;

        public event EventHandler OnRightMouseClick;

        public KeyboardMouseUserInput(Form form)
        {
            form.KeyDown += OnKeyDown;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    if (this.PressedZ != null)
                    {
                        this.PressedZ(this, new EventArgs());
                    }
                    break;
                case Keys.X:
                    if (this.PressedX != null)
                    {
                        this.PressedX(this, new EventArgs());
                    }
                    break;
                case Keys.C:
                    if (this.PressedC != null)
                    {
                        this.PressedC(this, new EventArgs());
                    }
                    break;
                case Keys.V:
                    if (this.PressedV != null)
                    {
                        this.PressedV(this, new EventArgs());
                    }
                    break;
                default:
                    break;
            }
        }

        
    }
}

namespace TowerDeffence.Helpers
{
    using System;
    using System.Windows.Forms;
    using TowerDeffence.Interfaces;
    public class KeyboardMouseUserInput : IUserInputHandler
    {
        public event EventHandler PressedZ; // Build tower

        public event EventHandler PressedX; // Sell tower

        public event EventHandler PressedC; // Upgrade tower

        public event EventHandler PressedV; // Remove tower

        public event EventHandler OnLeftMouseClick; // Select object

        public event EventHandler OnDoubleMouseClick; // Deselect object

        public event EventHandler OnRightMouseClick; // Object menu

        public KeyboardMouseUserInput(Form form)
        {
            form.KeyDown += OnKeyDown;
            form.MouseDown += OnMouseDown;
            form.MouseDoubleClick += OnMouseDoubleClick;
        }

        private void OnMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.OnDoubleMouseClick != null)
            {
                this.OnDoubleMouseClick(this, new EventArgs());
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (this.OnLeftMouseClick != null)
                    {
                        this.OnLeftMouseClick(this, new EventArgs());
                    }
                    break;
                case MouseButtons.Right:
                    if (this.OnRightMouseClick != null)
                    {
                        this.OnRightMouseClick(this, new EventArgs());
                    }
                    break;
            }
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

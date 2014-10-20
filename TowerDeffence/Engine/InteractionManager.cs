using System.Drawing;

namespace TowerDeffence.Engine
{
    using System.Windows.Forms;

    using Interfaces;

    public class InteractionManager : IInteractionManager
    {
        public void ShowGameMenu(Form form)
        {
            var btn = new Button {Text = @"Start Game", Location = new Point(325,225), Size = new Size(150, 150)};
            form.Controls.Add(btn);
        }
    }
}

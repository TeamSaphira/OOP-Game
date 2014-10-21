namespace TowerDeffence.Engine
{
    using System.Drawing;
    using System.Windows.Forms;

    using Interfaces;

    public class InteractionManager : IInteractionManager
    {
        public void ShowGameMenu(Form form)
        {
            var gameForm = (MainForm)form;
            //get image from loader
            // draw image
            // add buttons
            
            var btn = new Button {Text = @"Start Game", Location = new Point(325,225), Size = new Size(150, 150), CausesValidation = false, };

            var img = new Bitmap("test.jpg");
            var container = new ContainerControl() {Location = new Point(100, 50), Size = new Size(50,50)};
            container.BackgroundImage = new Bitmap(img, 50, 50);
            btn.Click += (sender, args) => gameForm.Engine.PlayLevel(1, gameForm);
            form.Controls.Add(btn);
            form.Controls.Add(container);
        }
    }
}

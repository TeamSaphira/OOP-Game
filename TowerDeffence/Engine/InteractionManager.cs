using System.Drawing.Text;
using System.IO;
using TowerDeffence.Properties;

namespace TowerDeffence.Engine
{
    using System.Drawing;
    using System.Windows.Forms;

    using Helpers;
    using Interfaces;

    public class InteractionManager
    {
        private static readonly string FontPath = @"..\..\Files\Font\MATURASC.TTF";

        public void ShowGameMenu(Form form)
        {
            var gameForm = InitForm(form);
            //get image from loader
            // draw image
            // add buttons

            var startBtn = new Button { Text = @"Start Game", Location = new Point(300, 225), Size = new Size(200, 50)};
            startBtn.Click += (sender, args) => gameForm.Engine.PlayLevel(1, gameForm);
            var highScoreBtn = new Button() { Text = @"Highscores", Location = new Point(300, 300), Size = new Size(200, 50)};
            highScoreBtn.Click += (sender, args) => gameForm.Engine.InteractionManager.ShowHighscore();
            var exitBtn = new Button() { Text = @"Exit Game", Location = new Point(300, 375), Size = new Size(200, 50)};
            exitBtn.Click += (sender, args) => Application.Exit();
            form.Controls.Add(startBtn);
            form.Controls.Add(highScoreBtn);
            form.Controls.Add(exitBtn);
        }

        public Position GetNextPosition(IMap map, IEnemyUnit unit)
        {
            // todo
            return new Position(0, 0); // seems legit :)
        }

        public void ShowHighscore()
        {
            throw new System.NotImplementedException();
        }

        private static Font InitFont(string fileName)
        {
            File.WriteAllBytes(fileName, Resources.MATURASC);
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile(fileName);

            var font = new Font(pfc.Families[0], 15);

            return font;
        }

        private static MainForm InitForm(Form form)
        {
            var gameForm = (MainForm)form;
            gameForm.Font = InitFont(InteractionManager.FontPath);
            gameForm.ClientSize = new Size(800, 600);

            return gameForm;
        }
    }
}

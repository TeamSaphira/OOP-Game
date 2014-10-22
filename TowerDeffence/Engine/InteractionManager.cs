namespace TowerDeffence.Engine
{
    using System.Drawing;
    using System.Drawing.Text;
    using System.IO;
    using System.Windows.Forms;
    
    using Helpers;
    using Interfaces;
    using Properties;

    public class InteractionManager
    {
        private static readonly string FontPath = @"..\..\Files\Font\MATURASC.TTF";

        public void ShowGameMenu(Form form)
        {
            var gameForm = InitForm(form);

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

        public Position GetNextPosition(IMap map, object unit)
        {
            var unitPosX = ((IPositionable) unit).Position.X;
            var unitPosY = ((IPositionable)unit).Position.Y;

            for (int i = 0; i < map.MapTiles.GetLength(0); i++)
            {
                for (int j = 0; j < map.MapTiles.GetLength(1); j++)
                {
                    var currentTile = map.MapTiles[i, j];
                    var currentTilePosition = currentTile.Position;
                }
            }
            return new Position(0,0);
        }

        public void ShowHighscore()
        {
            MessageBox.Show(@"Highscore");
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

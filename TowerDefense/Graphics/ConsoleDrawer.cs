namespace TowerDeffence.Graphics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    using Engine;
    using Helpers;
    using Interfaces;

    public class ConsoleDrawer : IRenderer
    {
        public void Draw(IList<IDrawable> drawables)
        {
            throw new NotImplementedException();
        }

        private void DrawPlayfieldBorder()
        {
            int width = ConsoleSettings.MaxWidth;
            int height = ConsoleSettings.MaxHeight;

            for (int i = 0; i < width - 1; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
            }

            for (int i = 1; i < height - 2; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
            }

            for (int i = 1; i < height - 2; i++)
            {
                Console.SetCursorPosition(width - 2, i);
                Console.Write("|");
            }

            for (int i = 1; i < width - 1; i++)
            {
                Console.SetCursorPosition(i, height - 2);
                Console.Write("-");
            }
        }

        private void DrawMenuSeparator()
        {
            int height = ConsoleSettings.MaxHeight;

            for (int i = 1; i < height - 2; i++)
            {
                Console.SetCursorPosition(ConsoleSettings.PlayfieldWidth, i);
                Console.Write('|');
            }
        }


        public void DrawGameMenu()
        {
            string text = LoadManager.Instance.ReadAllText("..\\..\\Files\\menu.txt");
            List<string> textLines = text.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var welcomeMessage = new StringBuilder();
            foreach (var textLine in textLines)
            {
                int padSymbols = (ConsoleSettings.MaxWidth - textLine.Length) / 2;
                welcomeMessage.Append(new string(' ', padSymbols));
                welcomeMessage.AppendLine(textLine);
            }

            Console.Write(welcomeMessage.ToString());

            Console.SetCursorPosition(ConsoleSettings.MaxWidth / 2,textLines.Count + 5);
        }


        public void DrawGameWindow()
        {
            DrawPlayfieldBorder();
            DrawMenuSeparator();
        }


        public void DrawAuthors()
        {

            string authorsText = LoadManager.Instance.ReadAllText("..\\..\\Files\\authors.txt");
            string[] textLines = authorsText.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            var authorsPadded = new StringBuilder();

            for (int i = 0; i < textLines.Length; i++)
            {
                int padSymbols;
                if (i < 4)
                {
                    padSymbols = (ConsoleSettings.MaxWidth - textLines[2].Trim().Length) / 2;
                }
                else
                {
                    padSymbols = (ConsoleSettings.MaxWidth - textLines[4].Trim().Length) / 2;
                }
                authorsPadded.Append(new string(' ', padSymbols));
                authorsPadded.AppendLine(textLines[i]);
            }

            Console.SetCursorPosition(0, 0);
            Console.Write(authorsPadded.ToString());
        }


        public void DrawGameInfo()
        {
            string infoText = LoadManager.Instance.ReadAllText("..\\..\\Files\\info.txt");
            string[] infoTextParts = infoText.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            int lastIndex = infoTextParts.Length - 1;
            int left = ConsoleSettings.PlayfieldWidth + (ConsoleSettings.MenuWidth - infoTextParts[lastIndex].Length) / 2;

            for (int i = 0; i < infoTextParts.Length; i++)
            {
                Console.SetCursorPosition(left, i + 1);
                Console.Write(infoTextParts[i]);
            }
        }


        public void DrawMap(IMap map, int left, int top)
        {
            int l = left;

            Console.SetCursorPosition(left, top);
            var tiles = map.MapTiles;
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    if (tiles[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write('#');
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write('*');
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }
                Console.SetCursorPosition(l, top + i);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DrawEnemiesInfo(IList<object> units)
        {
            for (int i = 0; i < units.Count; i++)
            {
                var enemy = (IEnemyUnit)units[i];
                var enemyHealthString = string.Empty;
                int enemyHealth = enemy.Health;

                int fifties = enemyHealth / 100;
                enemyHealthString += new string('#', fifties);

                Console.SetCursorPosition(ConsoleSettings.PlayfieldWidth + 2, i + 7);
                Console.Write(units[i].GetType().Name.PadRight(15) + " ->    ");
                Console.WriteLine(enemyHealthString);
            }
        }
    }
}

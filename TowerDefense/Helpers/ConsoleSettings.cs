using System;

namespace TowerDeffence.Helpers
{
    public static class ConsoleSettings
    {

        public static readonly int MaxWidth = Console.LargestWindowWidth - 1;
        public static readonly int MaxHeight = Console.LargestWindowHeight;
        public static readonly int MenuWidth = 40;
        public static readonly int PlayfieldWidth = MaxWidth - MenuWidth - 2;

        public static void SetupConsole()
        {
            Console.Title = "Saphira Defense";
            Console.WindowHeight = MaxHeight;
            Console.WindowWidth = MaxWidth;
            Console.BufferHeight = MaxHeight;
            Console.BufferWidth = MaxWidth;
            Console.SetWindowPosition(0, 0);
            Console.CursorVisible = false;
        }
    }
}

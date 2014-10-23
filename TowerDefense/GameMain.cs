using System;

namespace TowerDeffence
{
    using Engine;
    using GameObjects;
    using Graphics;
    using Helpers;

    static class GameMain
    {
        static void Main()
        {
            var engine = new Ngin(new Player("test", 10, 500), new KeyboardMouseUserInput(), new GamePlayfield(), new InteractionManager(), new RangeCollisionHandler(), new ConsoleDrawer() );

            ConsoleSettings.SetupConsole();

            engine.ShowGameMenu();
            engine.InitGame();
            engine.ReadCommand();

            Console.Read();
        }
    }
}

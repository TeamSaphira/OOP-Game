namespace TowerDeffence.Helpers
{
    using System;

    using Interfaces;

    public class KeyboardMouseUserInput : IUserInputHandler
    {
        private ConsoleKeyInfo pressedKey;
        private string input;

        public KeyboardMouseUserInput()
        {
            input = String.Empty;
        }

        public string ReadKey()
        {
            input = string.Empty;

            do
            {
                pressedKey = Console.ReadKey(true);

                if (pressedKey.Key != ConsoleKey.Backspace)
                {
                    input += pressedKey.KeyChar;
                }
                else
                {
                    Console.Write("\b");
                }
            } while (pressedKey.Key != ConsoleKey.Enter);

            input = input.Substring(0, 1);

            return input;
        }
    }
}
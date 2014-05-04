namespace CursorMoves
{
    using System;

    public class Game
    {
        /// <summary>
        /// Cursor to the left.
        /// </summary>
        public void OnLeft()
        {
            if (Console.CursorLeft > 0) 
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        /// <summary>
        /// Cursur to the right.
        /// </summary>
        public void OnRight()
        {
            if (Console.CursorLeft < Console.BufferWidth - 1)
                Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
        }

        /// <summary>
        /// Cursor up.
        /// </summary>
        public void OnUp()
        {
            if (Console.CursorTop > 0)
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
        }

        /// <summary>
        /// Cursor down.
        /// </summary>
        public void OnDown()
        {
            if (Console.CursorTop < Console.BufferHeight - 1)
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
        }
    }
}

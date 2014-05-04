namespace CursorMoves
{
    using System;

    public delegate void ArrowHandler();

    public class EventLoop
    {
        private ArrowHandler leftHandler;
        private ArrowHandler rightHandler;
        private ArrowHandler upHandler;
        private ArrowHandler downHandler;

        public void RegisterLeftHandler(ArrowHandler left)
        {
            leftHandler += left;
        }

        public void RegisterRightHandler(ArrowHandler right)
        {
            rightHandler += right;
        }

        public void RegisterUpHandler(ArrowHandler up)
        {
            upHandler += up;
        }

        public void RegisterDownHandler(ArrowHandler down)
        {
            downHandler += down;
        }

        /// <summary>
        /// Event loop.
        /// </summary>
        public void Run()
        {
            while (true)
            {
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                    {
                        if (leftHandler != null)
                            leftHandler();
                        break;
                    }
                    case ConsoleKey.RightArrow:
                    {
                        if (rightHandler != null)
                            rightHandler();
                        break;
                    }
                    case ConsoleKey.UpArrow:
                    {
                        if (upHandler != null)
                            upHandler();
                        break;
                    }
                    case ConsoleKey.DownArrow:
                    {
                        if (downHandler != null)
                            downHandler();
                        break;
                    }
                }
            }
        }
    }

}

namespace CursorMoves
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var game = new Game();

            eventLoop.RegisterLeftHandler(game.OnLeft);
            eventLoop.RegisterRightHandler(game.OnRight);
            eventLoop.RegisterUpHandler(game.OnUp);
            eventLoop.RegisterDownHandler(game.OnDown);

            eventLoop.Run();
        }
    }
}

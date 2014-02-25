using System;

namespace Homework_2
{
    public static class StackAsClass
    {
        public static void Main()
        {
            int a = 1;
            int b = 5;

            Stack stack = new Stack();

            // Verify that the program is working correctly
            stack.Push(a);
            stack.Push(b);

            Console.WriteLine("{0}", stack.Top().Value);

            stack.Pop();

            Console.WriteLine("{0}", stack.Top().Value);

            stack.Pop();
            stack.Pop();

            Console.WriteLine("{0}", stack.Top().Value);

            stack.Push(a);

            Console.WriteLine("{0}", stack.Top().Value);
        }
    }
}

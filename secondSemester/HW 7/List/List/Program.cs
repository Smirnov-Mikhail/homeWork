namespace List
{
    using System;

    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.PushFront(1);
            list.PushFront(2);
            list.PushFront(3);

            list.Insert(0, 2);

            list.OutPutList();
        }
    }
}

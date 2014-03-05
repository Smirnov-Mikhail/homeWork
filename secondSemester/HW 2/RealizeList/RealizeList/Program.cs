using System;

namespace RealizeList
{
    class Program
    {
        static void Main()
        {
            List list = new List();

            list.PushFront(1);
            list.PushFront(2);
            list.PushFront(3);

            list.InsertIndex(2, 0);

            list.OutPutList();
        }
    }
}

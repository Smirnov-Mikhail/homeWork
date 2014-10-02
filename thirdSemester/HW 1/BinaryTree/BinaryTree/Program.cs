namespace BinaryTreeNamespace
{
    using System;

    class Program
    {
        static void Main()
        {
            BinaryTree<Int32> tree = new BinaryTree<int>();
            
            tree.Add(5);
            tree.Delete(5);
            //tree.Add(10);
            //tree.Add(15);
            //tree.Add(20);
            //tree.Add(13);
           // tree.Add(12);
            if (tree.Exist(5))
            {
                Console.WriteLine("!!!");
            }

            tree.Print();
        }
    }
}

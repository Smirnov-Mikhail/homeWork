using System;
using HashTableNamespace;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hash = new HashTable(100);

            string str1 = "cat";

            int[] a = new int[2];

            hash.InsertToHash(str1);

           // hash.OutputHash();

            hash.ClearHash();

            hash.InsertToHash("dog");
            hash.InsertToHash("dabudi");
            hash.InsertToHash("horror");
            hash.InsertToHash("dog");
            hash.InsertToHash("hot");
            hash.InsertToHash("snow");

            hash.OutputHash();
        }
    }
}

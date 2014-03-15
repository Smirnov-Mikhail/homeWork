namespace HashTableNamespace
{
    using System;
    using ListNamespace;

    public class HashTable
    {
        private List[] array;
        private int size;

        public HashTable(int value)
        {
            size = value;
            array = new List[size];
            for (int i = 0; i < size; i++)
                array[i] = new List();
        }

        /// <summary>
        /// Add element in the hash table.
        /// </summary>
        /// <param name="array"> This list. </param>
        /// <param name="str"> Added element. </param>
        public void InsertToHash(string str)
        {
            array[HashFunction(str)].InsertValueInHash(str);
        }

        /// <summary>
        /// Show on the display elements of hash table.
        /// </summary>
        public void OutputHash()
        {
            for (int i = 0; i < size; i++)
            {
                array[i].OutputList();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Test hash for empty. (if hash is empty then return true)
        /// </summary>
        /// <returns></returns>
        public bool HashTestForEmpty()
        {
            for (int i = 0; i < size; i++)
                if (!array[i].TestForEmpty())
                    return false;
            return true;
        }

        /// <summary>
        /// Delete all elements of hash table.
        /// </summary>
        public void ClearHash()
        {
            for (int i = 0; i < size; i++)
                array[i].ClearList();
        }

        /// <summary>
        /// Hash function.
        /// </summary>
        /// <param name="str"> This string. </param>
        /// <returns></returns>
        private int HashFunction(string str)
        {
            int index = 0;
            for (int i = 1; i < str.Length; i++)
                index += (int)Math.Pow(3.0, (str.Length - i)) * Convert.ToInt32(str[i]);

            if (index < 0)
                index = -index;
            index %= size;

            return index;
        }
    }
}
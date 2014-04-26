namespace Hash
{
    using System;
    using ListNamespace;

    public class HashTable
    {
        private List[] array;
        private IHashFunction hashFunction;

        public HashTable(int value, IHashFunction hashFunction)
        {
            array = new List[value];
            for (int i = 0; i < array.Length; i++)
                array[i] = new List();

            this.hashFunction = hashFunction;
        }

        /// <summary>
        /// Add element in the hash table.
        /// </summary>
        /// <param name="str"> Added element. </param>
        public void InsertToHash(string str)
        {
            array[hashFunction.HashFunction(str, array.Length)].InsertValueInHash(str);
        }

        /// <summary>
        /// Show on the display elements of hash table.
        /// </summary>
        public void OutputHash()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].OutputList();
                Console.WriteLine();
            }
        }
        
        /// <summary>
        /// Delete element in the hash-table.
        /// </summary>
        /// <param name="str"> Deleted element. </param>
        public void DeleteElementInHash(string str)
        {
            array[hashFunction.HashFunction(str, array.Length)].DeleteElementInList(array[hashFunction.HashFunction(str, array.Length)].ReturnIndexOfElement(str));
        }
        
        /// <summary>
        /// Delete all elements of hash table.
        /// </summary>
        public void ClearHash()
        {
            for (int i = 0; i < array.Length; i++)
                array[i].ClearList();
        }

        /// <summary>
        /// Find element in the hash.
        /// </summary>
        /// <param name="str"> Found element. </param>
        /// <returns></returns>
        public bool FindElementInHash(string str)
        {
            if (array[hashFunction.HashFunction(str, array.Length)].FindElementInList(str))
                return true;

            return false;
        }

        /// <summary>
        /// Changed hash function and and moved all elements.
        /// </summary>
        /// <param name="choice"> Hash function. </param>
        public void ChangeHashFunction(IHashFunction otherHashFunction)
        {
            IHashFunction lastHashFunction = this.hashFunction;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].SizeOfList();)
                {
                    this.hashFunction = otherHashFunction;
                    // If the item is at the desired position.
                    if (hashFunction.HashFunction((string)array[i].ReturnValueOfElement(j), array.Length) == i)
                    {
                        j++;
                        continue;
                    }

                    object temp = array[i].ReturnValueOfElement(j);
                    this.hashFunction = lastHashFunction;
                    DeleteElementInHash((string)temp);

                    this.hashFunction = otherHashFunction;
                    InsertToHash((string)temp);
                }
            }
        }

        /// <summary>
        /// Test hash for empty. (if hash is empty then return true)
        /// </summary>
        /// <returns></returns>
        public bool HashTestForEmpty()
        {
            for (int i = 0; i < array.Length; i++)
                if (!array[i].TestForEmpty())
                    return false;

            return true;
        }
    }
}
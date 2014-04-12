namespace Hash
{
    using System;
    using ListNamespace;

    public class HashTable
    {
        private List[] array;
        private int choiceHashFunction;

        public HashTable(int value)
        {
            array = new List[value];
            for (int i = 0; i < array.Length; i++)
                array[i] = new List();
        }

        /// <summary>
        /// Add element in the hash table.
        /// </summary>
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
            array[HashFunction(str)].DeleteElementInList(array[HashFunction(str)].ReturnIndexOfElement(str));
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
            if (array[HashFunction(str)].FindElementInList(str))
                return true;

            return false;
        }

        /// <summary>
        /// Changed hash function and and moved all elements.
        /// </summary>
        /// <param name="choice"> Hash function. </param>
        public void ChangeHashFunction(int choice)
        {
            int lastHashFunction = choiceHashFunction;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].SizeOfList();)
                {
                    choiceHashFunction = choice;
                    // If the item is at the desired position.
                    if (HashFunction((string)array[i].ReturnValueOfElement(j)) == i)
                    {
                        j++;
                        continue;
                    }

                    object temp = array[i].ReturnValueOfElement(j);
                    choiceHashFunction = lastHashFunction;
                    DeleteElementInHash((string)temp);

                    choiceHashFunction = choice;
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

        /// <summary>
        /// Hash function.
        /// </summary>
        /// <param name="str"> This string. </param>
        /// <returns></returns>
        private int HashFunction(string str)
        {
            switch(choiceHashFunction)
            {
                case 0:
                    {
                        int index = 0;
                        for (int i = 1; i < str.Length; i++)
                            index += (int)Math.Pow(3.0, (str.Length - i)) * Convert.ToInt32(str[i]);

                        if (index < 0)
                            index = -index;

                        return index % array.Length;
                    }
                default:
                    {
                        return (str.Length * 1234) % array.Length;
                    }
            }
        }

    }
}
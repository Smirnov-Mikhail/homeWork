namespace Hash
{
    using System;

    /// <summary>
    /// First hash-function.
    /// </summary>
    public class HashFunction1 : IHashFunction
    {
        public int HashFunction(string str, int sizeOfHash)
        {
            int index = 0;
            for (int i = 1; i < str.Length; i++)
                index += (int)Math.Pow(3.0, (str.Length - i)) * Convert.ToInt32(str[i]);

            if (index < 0)
                index = -index;

            return index % sizeOfHash;
        }
    }
}

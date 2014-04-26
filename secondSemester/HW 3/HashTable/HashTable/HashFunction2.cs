namespace Hash
{
    using System;

    /// <summary>
    /// Second hash-function.
    /// </summary>
    public class HashFunction2 : IHashFunction
    {
        public int HashFunction(string str, int sizeOfHash)
        {
            return (str.Length * 1234) % sizeOfHash;
        }
    }
}

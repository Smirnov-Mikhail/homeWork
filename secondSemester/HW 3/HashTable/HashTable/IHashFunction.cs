namespace Hash
{
    using System;

    /// <summary>
    /// Function for hash-table.
    /// </summary>
    public interface IHashFunction
    {
       int HashFunction(string str, int sizeOfHash);
    }
}
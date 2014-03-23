namespace HashTable.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HashTableNamespace;
    using ListNamespace;

    [TestClass]
    public class HashTableTest
    {
        [TestInitialize]
        public void Initialize()
        {
            hash = new HashTable(100);
        }

        [TestMethod]
        public void InsertToHashTest()
        {
            string str = "cat";

            hash.InsertToHash(str);
            Assert.IsFalse(hash.HashTestForEmpty());
        }

        [TestMethod]
        public void FindElementInHashTest()
        {
            string str = "cat";

            hash.InsertToHash(str);
            Assert.IsTrue(hash.FindElementInHash(str));
        }
        
        [TestMethod]
        public void DeleteElementInHashTest()
        {
            string str = "cat";

            hash.DeleteElementInHash(str);
            Assert.IsTrue(hash.HashTestForEmpty());
        }
        
        [TestMethod]
        public void ClearHashTest()
        {
            string str = "cat";

            hash.InsertToHash(str);

            hash.ClearHash();

            Assert.IsTrue(hash.HashTestForEmpty());
        }

        private HashTable hash;
    }
}

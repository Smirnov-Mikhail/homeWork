﻿namespace HashTable.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Hash;
    //using ListNamespace;

    [TestClass]
    public class HashTableTest
    {
        [TestInitialize]
        public void Initialize()
        {
            hashFunction1 = new HashFunction1();
            hash = new HashTable(10, hashFunction1);

            hashFunction2 = new HashFunction2();
        }

        [TestMethod]
        public void TestForEmpty()
        {
            Assert.IsTrue(hash.HashTestForEmpty());
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

        [TestMethod]
        public void ChangeHashFunctionTest()
        {
            string str1 = "cat";
            string str2 = "kitty";

            hash.InsertToHash(str1);
            hash.InsertToHash(str2);

            hash.ChangeHashFunction(hashFunction2);

            Assert.IsTrue(hash.FindElementInHash(str1) && hash.FindElementInHash(str2));
        }

        private HashTable hash;
        HashFunction1 hashFunction1;
        HashFunction2 hashFunction2;
    }
}

namespace RealizeStack.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ListNamespace;

    [TestClass]
    public class ListTest
    {

        [TestInitialize]
        public void Initialize()
        {
            list = new List();
        }

        [TestMethod]
        public void PushFrontTest()
        {
            list.PushFront(1);
            Assert.IsFalse(list.TestForEmpty());
        }

        [TestMethod]
        public void PushBackTest()
        {
            list.PushBack(1);
            Assert.IsFalse(list.TestForEmpty());
        }
        
        /// <summary>
        /// Insert to non-existent position. (indexs from 1 to size)
        /// </summary>
        [TestMethod]
        public void InsertIndexTest1()
        {
            list.InsertIndex(1, -1);
            Assert.IsTrue(list.TestForEmpty());
        }

        [TestMethod]
        public void InsertIndexTest2()
        {
            list.InsertIndex(1, 0);
            Assert.IsFalse(list.TestForEmpty());
        }
        
        [TestMethod]
        public void ReturnValueOfElementTest()
        {
            list.PushFront(1);
            Assert.AreEqual(list.ReturnValueOfElement(0), 1);
        }

        [TestMethod]
        public void InsertIndexTest3()
        {
            list.PushFront(1);
            list.PushFront(2);
            list.PushFront(3);

            list.InsertIndex(0, 2);

            Assert.AreEqual(list.ReturnValueOfElement(2), 0);
        }

        [TestMethod]
        public void FindElementInListTest()
        {
            list.PushFront("1");
            list.PushFront("2");
            list.PushFront("3");

            Assert.IsTrue(list.FindElementInList("2"));
        }
        
        [TestMethod]
        public void ReturnIndexOfElementTest()
        {
            list.PushFront("1");
            list.PushFront("2");
            list.PushFront("3");

            Assert.AreEqual(list.ReturnIndexOfElement("3"), 0);
        }
        
        [TestMethod]
        public void DeleteElementInListTest()
        {
            list.PushFront(1);

            list.DeleteElementInList(0);

            Assert.IsTrue(list.TestForEmpty());
        }

        [TestMethod]
        public void ClearListTest()
        {
            list.PushFront(1);
            list.PushFront(2);
            list.PushFront(3);

            list.ClearList();

            Assert.IsTrue(list.TestForEmpty());
        }

        // Next tests for list with frequency of elements.

        [TestMethod]
        public void InsertInsertValueInHash1()
        {
            list.InsertValueInHash("kitty");
            Assert.IsFalse(list.TestForEmpty());
        }


        [TestMethod]
        public void InsertInsertValueInHash2()
        {
            list.InsertValueInHash("kitty");
            list.InsertValueInHash("kitty");

            Assert.AreEqual(list.ReturnFrequencyOfElement(0), 2);
        }

        private List list;

    }
}
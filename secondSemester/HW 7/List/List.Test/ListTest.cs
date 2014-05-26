namespace List.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using List;

    [TestClass]
    public class ListTest
    {
        [TestInitialize]
        public void Initialize()
        {
            list = new List<int>();
        }

        [TestMethod]
        public void StartEmptyTest()
        {
            Assert.IsTrue(list.TestForEmpty());
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
        /// Insert to non-existent position.
        /// </summary>
        [TestMethod]
        public void InsertTest1()
        {
            list.Insert(1, -1);
            Assert.IsTrue(list.TestForEmpty());
        }

        [TestMethod]
        public void InsertTest2()
        {
            list.Insert(1, 0);
            Assert.IsFalse(list.TestForEmpty());
        }

        [TestMethod]
        public void ReturnValueOfElementTest()
        {
            list.PushFront(1);
            Assert.AreEqual(list.ReturnValueOfElement(0), 1);
        }

        [TestMethod]
        public void InsertTest3()
        {
            list.PushFront(1);
            list.PushFront(2);
            list.PushFront(3);

            list.Insert(0, 2);

            Assert.AreEqual(list.ReturnValueOfElement(2), 0);
        }

        [TestMethod]
        public void ClearTest()
        {
            list.PushFront(1);
            list.PushFront(2);
            list.PushFront(3);

            list.Clear();

            Assert.IsTrue(list.TestForEmpty());
        }

        [TestMethod]
        public void InsertIndexTestTryingToAddAfterFirst()
        {
            list.PushFront(1);
            list.Insert(2, 1);
            Assert.AreEqual(2, list.ReturnValueOfElement(1));
        }

        [TestMethod]
        public void ForeachTest()
        { 
            list.PushFront(2);
            list.PushFront(1);
            list.PushFront(4);
            list.PushFront(-1);

            int result = 0;
            foreach (var x in list)
                result += x;
            
            Assert.IsTrue(result == 6);
        }

        private List<int> list;
    }
}

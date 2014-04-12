namespace UniqueList.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UniqueListTest
    {
        [TestInitialize]
        public void Initialize()
        {
            list = new UniqueList();
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

        [TestMethod]
        public void InsertIndexTest1()
        {
            list.InsertIndex(1, 0);
            Assert.IsFalse(list.TestForEmpty());
        }

        [TestMethod]
        public void InsertIndexTest2()
        {
            list.PushFront(1);
            list.PushFront(2);
            list.InsertIndex(5, 1);
            Assert.AreEqual(5, list.ReturnValueOfElement(1));
        }

        [TestMethod]
        [ExpectedException(typeof(RepeatException))]
        public void ExceptionForIntTest()
        {
            list.PushFront(1);
            list.PushFront(1);
        }

        [TestMethod]
        [ExpectedException(typeof(DeletedNonExistent))]
        public void DeleteElementInListTest()
        {
            list.PushFront(1);
            list.DeleteElementInList(1);
        }

        private UniqueList list;
    }
}

namespace StackPoint.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StackCalculator;

    [TestClass]
    public class StackPointTest
    {
        [TestInitialize]
        public void Initialize()
        {
            stack = new StackPoint();
        }
        
        [TestMethod]
        public void PushTest()
        {
            stack.Push(1);
            Assert.IsFalse(stack.TestForEmpty());
        }

        [TestMethod]
        public void PopTest()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void TopTest()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Top());
        }

        [TestMethod]
        public void TwoElementsPopTest()
        {
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void PopFromEmptyStackTest()
        {
            stack.Pop();
        }

        [TestMethod]
        public void ClearStackTest()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(0);
            stack.ClearStack();
            Assert.IsTrue(stack.TestForEmpty());   
        }
        
        private StackPoint stack;
         
    }
}
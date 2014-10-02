namespace BinaryTreeTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BinaryTreeNamespace;

    [TestClass]
    public class BinaryTreeTest 
    {
        [TestInitialize]
        public void Initialize()
        {
            treeInt = new BinaryTree<int>();
            treeChar = new BinaryTree<char>();
        }

        /// <summary>
        /// Test for start empty.
        /// </summary>
        [TestMethod]
        public void TestForEmptyIntTest()
        {
            Assert.IsTrue(treeInt.TestForEmpty());
        }

        [TestMethod]
        public void TestForEmptyCharTest()
        {
            Assert.IsTrue(treeChar.TestForEmpty());
        }

        /// <summary>
        /// Test for add in tree.
        /// </summary>
        [TestMethod]
        public void AddIntTest()
        {
            treeInt.Add(5);
            Assert.IsFalse(treeInt.TestForEmpty());
        }

        [TestMethod]
        public void AddCharTest()
        {
            treeChar.Add('5');
            Assert.IsFalse(treeChar.TestForEmpty());
        }

        /// <summary>
        /// Test for exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AddRepeatElementException))]
        public void ExceptionForIntTest()
        {
            treeInt.Add(5);
            treeInt.Add(5);
        }

        [TestMethod]
        [ExpectedException(typeof(AddRepeatElementException))]
        public void ExceptionForCharTest()
        {
            treeChar.Add('5');
            treeChar.Add('5');
        }

        /// <summary>
        /// Test for exist element in tree.
        /// </summary>
        [TestMethod]
        public void ExistElementIntTest()
        {
            treeInt.Add(5);
            treeInt.Add(10);
            treeInt.Add(15);
            treeInt.Add(20);
            treeInt.Add(13);
            treeInt.Add(12);

            Assert.IsTrue(treeInt.Exist(13));
        }

        [TestMethod]
        public void ExistElementCharTest()
        {
            treeChar.Add('5');
            treeChar.Add('1');
            treeChar.Add('7');
            treeChar.Add('9');
            treeChar.Add('0');
            treeChar.Add('6');

            Assert.IsTrue(treeChar.Exist('0'));
        }

        /// <summary>
        /// Test for delete element in tree.
        /// </summary>
        [TestMethod]
        public void DeleteElementIntTest1()
        {
            treeInt.Add(5);
            treeInt.Delete(5);

            Assert.IsFalse(treeInt.Exist(5));
        }

        [TestMethod]
        public void DeleteElementIntTest2()
        {
            treeInt.Add(5);
            treeInt.Add(4);
            treeInt.Add(6);

            treeInt.Delete(5);

            Assert.IsFalse(treeInt.Exist(5));
        }

        [TestMethod]
        public void DeleteElementIntTest3()
        {
            treeInt.Add(5);
            treeInt.Add(4);
            treeInt.Add(7);
            treeInt.Add(8);
            treeInt.Add(6);

            treeInt.Delete(7);

            Assert.IsFalse(treeInt.Exist(7));
        }

        [TestMethod]
        public void DeleteElementIntTest4()
        {
            treeInt.Add(10);
            treeInt.Add(20);
            treeInt.Add(5);
            treeInt.Add(8);
            treeInt.Add(1);
            treeInt.Add(2);
            treeInt.Add(3);
            treeInt.Add(4);

            treeInt.Delete(5);

            Assert.IsFalse(treeInt.Exist(5));
        }

        [TestMethod]
        public void DeleteElementCharTest()
        {
            treeChar.Add('5');
            treeChar.Add('4');
            treeChar.Add('6');
            treeChar.Add('8');

            treeChar.Delete('6');

            Assert.IsFalse(treeChar.Exist('6'));
        }

        [TestMethod]
        public void ForeachTest()
        {
            treeInt.Add(1);
            treeInt.Add(2);
            treeInt.Add(3);
            treeInt.Add(4);
            treeInt.Add(5);
            treeInt.Add(6);

            int result = 0;
            foreach (var x in treeInt)
                result += x;

            Assert.IsTrue(result == 21);
        }

        private BinaryTree<int> treeInt;
        private BinaryTree<char> treeChar;
    }
}
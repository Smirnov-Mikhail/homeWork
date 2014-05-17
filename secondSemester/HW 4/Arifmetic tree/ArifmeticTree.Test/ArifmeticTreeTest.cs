namespace ArifmeticTree.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ArifmeticTree;

    [TestClass]
    public class ArifmeticTreeTest
    {
        [TestInitialize]
        public void Initialize()
        {
            tree1 = new Tree("(* (+ 11 1) (- 1 2))");
        }
        
        /// <summary>
        /// Test for exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DivisionByZeroException))]
        public void ExceptionForDivisionTest()
        {
            Tree tree2 = new Tree("( / 1 0 )");
            tree2.CalculateTree();
        }

        /// <summary>
        /// Test for exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InadmissibleSymbolException))]
        public void ExceptionInadmissibleSymbolTest()
        {
            Tree tree2 = new Tree("( % + 1 1 )");
            tree2.CalculateTree();
        }

        /// <summary>
        /// Test for correct calculation.
        /// </summary>
        [TestMethod]
        public void CalculateTest()
        {
            Assert.AreEqual(tree1.CalculateTree(), -12);
        }

        /// <summary>
        /// Test for correct print.
        /// </summary>
        [TestMethod]
        public void PrintTest()
        {
            Assert.AreEqual(tree1.PrintTree(), "(* (+ 11 1) (- 1 2))");
        }
        
        private Tree tree1;
    }
}   
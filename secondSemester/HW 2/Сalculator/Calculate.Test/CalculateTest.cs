namespace Calculate.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StackArrayNamespace;
    using StackPointNamespace;
    using StackCalculatornamespace;

    [TestClass]
    public class StackArrayTest
    {
        [TestInitialize]
        public void Initialize()
        {
            stackPoint = new StackPoint();
            stackArray = new StackArray();
        }

        /// <summary>
        /// Test for stackPoint.
        /// </summary>
        [TestMethod]
        public void ResultByPostfixFormTest1()
        {
            string line = "96+12-*";

            calc = new StackCalculator(line);

            Assert.AreEqual(-15, calc.ResultByPostfixForm(stackPoint));
        }

        /// <summary>
        /// Test for StackArray.
        /// </summary>
        [TestMethod]
        public void ResultByPostfixFormTest2()
        {
            string line = "23+4*56*-";

            calc = new StackCalculator(line);

            Assert.AreEqual(-10, calc.ResultByPostfixForm(stackArray));
        }
        

        private StackPoint stackPoint;
        private StackArray stackArray;
        private StackCalculator calc;

    }
}

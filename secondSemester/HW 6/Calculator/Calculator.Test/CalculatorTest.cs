namespace Calculator.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CalculatorNamespace;

    [TestClass]
    public class CalculatorTest
    {
        [TestInitialize]
        public void Initialize()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void AddNumberTest()
        {
            calculator.AddNumber(5);
            Assert.AreEqual(calculator.ReturnFirstNumber(), 5);
        }

        [TestMethod]
        public void AddOperationTest()
        {
            calculator.AddOperation("+");
            Assert.AreEqual(calculator.ReturnOperation(), "+");
        }

        [TestMethod]
        public void CalculateAnswerTest()
        {
            calculator.AddNumber(5);
            calculator.AddOperation("+");
            calculator.AddNumber(5);
            Assert.AreEqual(calculator.CalculateAnswer(), 10);
        }

        [TestMethod]
        public void ClearAllTest()
        {
            calculator.AddNumber(5);
            calculator.AddOperation("+");
            calculator.AddNumber(5);
            calculator.ClearAll();
            Assert.IsTrue(calculator.ReturnFirstNumber() == 0 && calculator.ReturnSecondNumber() == 0
                && calculator.ReturnOperation() == "" && calculator.state == (int)States.none);
        }

        [TestMethod]
        public void AddPointTest()
        {
            calculator.AddNumber(10);
            calculator.AddOperation("*");
            calculator.AddNumber(0);
            calculator.AddPoint();
            calculator.AddNumber(1);
            Assert.AreEqual(calculator.CalculateAnswer(), 1);
        }

        /// <summary>
        /// Test for exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideByZeroExceptionTest()
        {
            calculator.AddNumber(2);
            calculator.AddOperation("/");
            calculator.AddNumber(0);
            calculator.CalculateAnswer();
        }

        private Calculator calculator;
    }
}

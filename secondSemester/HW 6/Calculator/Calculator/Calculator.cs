namespace CalculatorNamespace
{
    using System;

    /// <summary>
    /// Class of calculator.
    /// </summary>
    public class Calculator
    {
        public int state;

        /// <summary>
        /// Add operand(number) in the expression.
        /// </summary>
        /// <param name="number"> Added element. </param>
        public void AddNumber(int number)
        {
            if (state == (int)States.none || state == (int)States.operationAdd || state == (int)States.answer)
            {
                if (state == (int)States.none || state == (int)States.answer)
                {
                    firstNumber = number;
                    state = (int)States.firstNumberEnter;
                }
                else
                {
                    secondNumber = number;
                    state = (int)States.secondNumberEnter;
                }
                factor = 10;
            }

            else if (state == (int)States.firstNumberEnter || state == (int)States.secondNumberEnter)
            {
                if (state == (int)States.firstNumberEnter)
                    firstNumber = number + firstNumber * factor;
                else
                    secondNumber = number + secondNumber * factor;
            }

            else
            {
                if (state == (int)States.firstNumberFraction || state == (int)States.firstNumberPoint)
                {
                    firstNumber += factor * number;
                    state = (int)States.firstNumberFraction;
                }
                else if (state == (int)States.secondNumberEnter || state == (int)States.secondNumberPoint)
                {
                    secondNumber += factor * number;
                    state = (int)States.secondNumberFraction;
                }
                factor /= 10;
            }
        }

        /// <summary>
        /// Add point of number.
        /// </summary>
        public void AddPoint()
        {
            if (state == (int)States.firstNumberEnter)
                state = (int)States.firstNumberPoint;
	        else
                state = (int)States.secondNumberPoint;
	        factor = 0.1;
        }

        /// <summary>
        /// Add operator in the expression.
        /// </summary>
        /// <param name="newOperation"></param>
        public void AddOperation(string newOperation)
        {
            if (state == (int)States.secondNumberFraction || state == (int)States.secondNumberEnter)
		        AnswerToFirstNumber();
	        oper = newOperation;
            state = (int)States.operationAdd;
        }

        /// <summary>
        /// Calculate expression.
        /// </summary>
        /// <returns></returns>
        public double CalculateAnswer()
        {
            if (oper == "+")
                return firstNumber + secondNumber;
            else if (oper == "-")
                return firstNumber - secondNumber;
            else if (oper == "*")
                return firstNumber * secondNumber;
            else if (secondNumber == 0)
                throw new DivideByZeroException();
            else
                return firstNumber / secondNumber;
        }

        /// <summary>
        /// Calculate expression.
        /// </summary>
        public void AnswerToFirstNumber()
        {
	        firstNumber = CalculateAnswer();
        }

        /// <summary>
        /// Delete all data.
        /// </summary>
        public void ClearAll()
        {
	        firstNumber = 0;
	        secondNumber = 0;
	        oper = "";
            state = (int)States.none;
        }

        /// <summary>
        /// Return first number(operand) in expression.
        /// </summary>
        /// <returns></returns>
        public double ReturnFirstNumber()
        {
            return firstNumber;
        }

        /// <summary>
        /// Return second number(operand) in expression.
        /// </summary>
        /// <returns></returns>
        public double ReturnSecondNumber()
        {
            return secondNumber;
        }

        /// <summary>
        /// Return operation in expression.
        /// </summary>
        /// <returns></returns>
        public string ReturnOperation()
        {   
            return oper;
        }

        private double firstNumber;
        private double secondNumber;
        private double factor;
        private string oper; 
    }

    /// <summary>
    /// Possible states calculator.
    /// </summary>
    public enum States
    {
        none,
        firstNumberEnter,
        firstNumberPoint,
        firstNumberFraction,
        operationAdd,
        secondNumberEnter,
        secondNumberPoint,
        secondNumberFraction,
        answer
    };
}

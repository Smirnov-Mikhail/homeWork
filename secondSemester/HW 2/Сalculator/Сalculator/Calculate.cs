namespace StackCalculatornamespace
{
    using System;
    using IStacknamespace;

    public class StackCalculator
    {
        private IStack stack;

        public StackCalculator(IStack mainStack)
        {
            stack = mainStack;
        }

        /// <summary>
        /// Calculate an expression in postfix form.
        /// </summary>
        /// <param name="stack"> </param>
        /// <returns></returns>
        public int ResultByPostfixForm(String str)
        {
	        int temp = 0;
            int po = 0;
            
	        for (int i = 0; i < str.Length; i++)
	        {
		        if (str[i] - '0' >= 0 && str[i] - '0' <= 9)
		        {
			        stack.Push(str[i].ToString());
		        }
		        else
		        {
                    Int32.TryParse((string)stack.Pop(), out temp);
                    Int32.TryParse((string)stack.Pop(), out po);
			        temp = Operation(po, temp, str[i]);
                    stack.Push(temp.ToString());
		        }
	        }

            Int32.TryParse((string)stack.Pop(), out temp);

            stack.ClearStack();

	        return temp;
        }

        /// <summary>
        /// Performs a binary operation.
        /// </summary>
        /// <param name="a1"> First value. </param>
        /// <param name="a2"> Second value. </param>
        /// <param name="value"> Operation. </param>
        /// <returns></returns>
        private int Operation(int a1, int a2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return a1 + a2;
                case '-':
                    return a1 - a2;
                case '*':
                    return a1 * a2;
                case '/':
                    return a1 / a2;
            }

            return 1;
        }
    }
}
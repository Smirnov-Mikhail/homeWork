namespace ArifmeticTree
{
    using System;

    /// <summary>
    /// Class of tree.
    /// </summary>
    public class Tree
    {
        private Node TreeHead;

        private int i;
        
        public Tree(string str)
        {
            i = 0;
            TreeHead = BuildTree(str);
        }

        /// <summary>
        /// Calculate tree.
        /// </summary>
        /// <returns></returns>
        public double CalculateTree()
        {
            return TreeHead.Calculate();
        }

        /// <summary>
        /// Output tree.
        /// </summary>
        /// <returns></returns>
        public string PrintTree()
        {
            return TreeHead.Print();
        }

        /// <summary>
        /// Load data into a tree.
        /// </summary>
        /// <param name="str"> This data. </param>
        /// <returns></returns>
        private Node BuildTree(string str)
        {
            while (isBracketOrSpace(str[i]))
                i++;

            if (!isOperator(str[i]) && !(str[i] >= '0' && str[i] <= '9'))
                throw new InadmissibleSymbolException();

		    if (isOperator(str[i]))
		    {
			    var newNode = CreateOperator(str[i]);
			    i++;

                newNode.Left = BuildTree(str);
                newNode.Right = BuildTree(str);

                return newNode;
		    }
		    else 
		    {
                string temp = Convert.ToString(str[i]);

                i++;
                if ( i < str.Length)
                    while (str[i] >= '0' && str[i] <= '9')
                    {
                        temp += str[i];
                        i++;
                    }

			    var newNode = CreateOperand(temp);
                return newNode;
		    }
        }

        private Operator CreateOperator(char symbol)
        {
            if (symbol == '-')
                return new Subtraction();
            else if (symbol == '+')
                return new Addition();
            else if (symbol == '/')
                return new Division();
            else
                return new Multiplication();
        }  

        private Operand CreateOperand(string str)
        {
            return new Operand(str);
        }

        private bool isBracketOrSpace(char symbol)
        {
            return symbol == '(' || symbol == ')' || symbol == ' ';
        }

        private bool isOperator(char symbol)
        {
            return symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/';
        }
    }
}

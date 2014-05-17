namespace ArifmeticTree
{
    using System;

    /// <summary>
    /// Subtraction operation.
    /// </summary>
    class Subtraction : Operator
    {
        public override double Calculate()
        {
            return Left.Calculate() - Right.Calculate();
        }

        public override string PrintSymbol()
        {
            return "-";
        }
    }
}

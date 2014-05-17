namespace ArifmeticTree
{
    using System;

    /// <summary>
    /// Multiplication operation.
    /// </summary>
    class Multiplication : Operator
    {
        public override double Calculate()
        {
            return Left.Calculate() * Right.Calculate();
        }

        public override string PrintSymbol()
        {
            return "*";
        }
    }
}

namespace ArifmeticTree
{
    using System;

    /// <summary>
    /// Division operation.
    /// </summary>
    public class Division : Operator
    {
        public override double Calculate()
        {
            // If we divide by zero.
            if (Right.Calculate() == 0)
                throw new DivisionByZeroException();

            return Left.Calculate() / Right.Calculate();
        }

        public override string PrintSymbol()
        {
            return "/";
        }
    }
}

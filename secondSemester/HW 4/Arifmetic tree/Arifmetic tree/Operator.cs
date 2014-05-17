namespace ArifmeticTree
{
    using System;

    /// <summary>
    /// Expression operator.
    /// </summary>
    public abstract class Operator : Node
    {
        private string Value { get; set; }

        public Node Right { get; set; }
        public Node Left { get; set; }

        public override string Print()
        {
            return "(" + PrintSymbol() + " " + this.Left.Print() + " " + this.Right.Print() + ")";
        }

        public abstract string PrintSymbol();

        
    }
}
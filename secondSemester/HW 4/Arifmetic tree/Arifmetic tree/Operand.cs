namespace ArifmeticTree
{
    using System;

    /// <summary>
    /// Expression operand.
    /// </summary>
    public class Operand : Node
    {
        private string Value { get; set; }

        public Operand(string value)
        {
            this.Value = value;
        }

        public override double Calculate()
        {
            return Convert.ToInt32(Value);
        }

        public override string Print()
        {
            return this.Value;
        }
    }
}

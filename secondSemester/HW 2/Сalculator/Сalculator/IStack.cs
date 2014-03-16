namespace IStacknamespace
{
    using System;

    /// <summary>
    /// Interface for stack.
    /// </summary>
    public interface IStack
    {
        void Push(object value);

        object Pop();

        object Top();

        void ClearStack();
    }
}
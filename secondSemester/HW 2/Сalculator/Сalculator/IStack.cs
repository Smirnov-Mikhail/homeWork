namespace StackCalculator
{
    using System;

    /// <summary>
    /// Interface for stack.
    /// </summary>
    public interface IStack
    {
        /// <summary>
        /// Add element in start of stack.
        /// </summary>
        /// <param name="value"> Added element. </param>
        void Push(object value);

        /// <summary>
        /// Delete first element and return its.
        /// </summary>
        /// <returns></returns>
        object Pop();

        /// <summary>
        /// Return first element.
        /// </summary>
        /// <returns></returns>
        object Top();

        /// <summary>
        /// Delete all elements in stack.
        /// </summary>
        void ClearStack();
    }
}
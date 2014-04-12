namespace StackCalculator
{
    using System;

    public class StackArray : IStack
    {
        private object[] array = new object[100];
        private int size;

        public StackArray() { }

        /// <summary>
        /// Add element in start of stack.
        /// </summary>
        /// <param name="value"> Added element. </param>
        public void Push(object value)
        {
            if (size == 100)
                throw new Exception();

            array[size] = value;

            Count++;
        }

        /// <summary>
        /// Return first element.
        /// </summary>
        /// <returns></returns>
        public object Top()
        {
            if (array[0] == null)
                return null;
            else
                return array[size - 1];
        }

        /// <summary>
        /// Delete first element and return its.
        /// </summary>
        /// <returns></returns>
        public object Pop()
        {
            if (array[0] == null)
                return null;
            else
            {
                Count--;

                return array[size];
            }
        }

        /// <summary>
        /// Delete all elements in stack.
        /// </summary>
        public void ClearStack()
        {
            array[0] = null;
            size = 0;
        }

        /// <summary>
        /// Test stack for empty. (if stack is empty then return true)
        /// </summary>
        /// <returns></returns>
        public bool TestForEmpty()
        {
            return size == 0;
        }

        /// <summary>
        /// Property for size.
        /// </summary>
        public int Count
        {
            get { return size; }
            set { size = value; }
        }
    }
}
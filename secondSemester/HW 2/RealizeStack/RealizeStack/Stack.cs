namespace StackNamespace
{
    public class Stack
    {
        private StackElement first;
        private int size;

        public Stack() { }

        /// <summary>
        /// Add element in start of stack.
        /// </summary>
        /// <param name="value"> Added element. </param>
        public void Push(object value)
        {
            StackElement newElement = new StackElement(value);

            newElement.Next = first;
            first = newElement;

            Count++;
        }

        /// <summary>
        /// Return first element.
        /// </summary>
        /// <returns></returns>
        public object Top()
        {
            if (first == null)
                return null;
            else
                return first.Value;
        }

        /// <summary>
        /// Delete first element and return its.
        /// </summary>
        /// <returns></returns>
        public object Pop()
        {
            if (first == null)
                return null;
            else
            {
                StackElement temp = first;
                first = first.Next;

                Count--;

                return temp.Value;
            }
        }

        /// <summary>
        /// Delete all elements in stack.
        /// </summary>
        public void ClearStack()
        {
            first = null;
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

        /// <summary>
        /// Element of the stack.
        /// </summary>
        private class StackElement
        {
            private object data;
            private StackElement next;

            public object Value
            {
                get { return data; }
                set { data = value; }
            }

            public StackElement(object element)
            {
                this.data = element;
            }

            /// <summary>
            /// Next element of the stack.
            /// </summary>
            public StackElement Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }
    }
}
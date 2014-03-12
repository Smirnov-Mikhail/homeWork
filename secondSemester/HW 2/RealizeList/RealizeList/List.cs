namespace ListNamespace
{
    using System;

    public class List
    {
        private ListElement first;
        private ListElement current;
        private ListElement last;
        private int size;

        public List() { }

        /// <summary>
        /// Add element in front of stack.
        /// </summary>
        /// <param name="value"> Added element. </param>
        public void PushFront(object value)
        {
            ListElement newElement = new ListElement(value);

            newElement.Next = first;
            first = newElement;

            Count++;
        }

        /// <summary>
        /// Add element in back of stack.
        /// </summary>
        /// <param name="value"> Added element. </param>
        public void PushBack(object value)
        {
            ListElement newElement = new ListElement(value);

            if (first == null)
            {
                first = newElement;
                last = newElement;
            }
            else
            {
                last.Next = newElement;
                last = newElement;
            }
            Count++;
        }

        /// <summary>
        /// Add element to the desired position of stack.
        /// </summary>
        /// <param name="newElement"> Added element. </param>
        /// <param name="index"> Index of desired position. (if index does not satisfy then the method does nothing) </param>
        public void InsertIndex(object value, int index)
        {
            if (index < 1 || index > size + 1)
            {
                return;
            }
            else if (index == 1) // if inserted to the front
            {
                ListElement newElement = new ListElement(value);

                newElement.Next = first;
                first = newElement;

                Count++;
            }
            else if (index == size) //if inserted to the back
            {
                PushBack(value);
            }
            else
            {
                int count = 1;
                current = first;
                while (current != null && count != index - 1)
                {
                    current = current.Next;
                    count++;
                }

                ListElement newElement = new ListElement(value);
                newElement.Next = current.Next;
                current.Next = newElement;
            }
        }

        /// <summary>
        /// Show on the display elements of list.
        /// </summary>
        public void OutPutList()
        {
            if (first == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            current = first;
            while (current != null)
            {
                Console.Write("{0} ", current.Value);
                current = current.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Return value of element.
        /// </summary>
        /// <param name="index"> Index returned element. </param>
        /// <returns></returns>
        public object ReturnValueOfElement(int index)
        {
            if (index < 1 || index > size + 1 || first == null)
            {
                return null;
            }
            else
            {
                current = first;
                int count = 1;

                while (current != null)
                {
                    if (count == index)
                        return current.Value;
                    count++;
                    current = current.Next;
                }

                return current.Value;
            }
        }

        /// <summary>
        /// Delete all elements in list.
        /// </summary>
        public void ClearList()
        {
            first = null;
            size = 0;
        }

        /// <summary>
        /// Test list for empty. (if list is empty then return true)
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

        private class ListElement
        {
            private object data;
            private ListElement next;

            public object Value
            {
                get { return data; }
                set { data = value; }
            }

            public ListElement(object element)
            {
                this.data = element;
            }

            /// <summary>
            /// Next element of the list.
            /// </summary>
            public ListElement Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }
    }
}
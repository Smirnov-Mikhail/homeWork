namespace ListNamespace
{
    using System;

    public class List
    {
        private ListElement first;
        private ListElement current;
        private ListElement last;

        /// <summary>
        /// Add element in front of list.
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
        /// Add element in back of list.
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
        /// Add element to the desired position of list.
        /// </summary>
        /// <param name="newElement"> Added element. </param>
        /// <param name="index"> Index of desired position. (if index does not satisfy then the method does nothing) </param>
        public void InsertIndex(object value, int index)
        {
            if (index < 0 || index > Count)
            {
                return;
            }
            else if (index == 0) // if inserted to the front
            {
                ListElement newElement = new ListElement(value);

                newElement.Next = first;
                first = newElement;

                Count++;
            }
            else if (index == Count) //if inserted to the back
            {
                PushBack(value);
            }
            else
            {
                int count = 0;
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
        public void OutputList()
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
            if (index < 0 || index > Count || first == null)
            {
                return null;
            }
            else
            {
                current = first;
                int count = 0;

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
        /// Return index of element.
        /// </summary>
        /// <param name="element"> This element. </param>
        /// <returns></returns>
        public int ReturnIndexOfElement(object element)
        {
            current = first;
            int count = 0;

            while (current != null)
            {
                if (current.Value == element)
                    return count;
                count++;
                current = current.Next;
            }

            return -1;
        }

        /// <summary>
        /// Insert the item given repetition.
        /// </summary>
        /// <param name="value"> Added element. </param>
        public void InsertValueInHash(object value)
        {
            int count = 1;
            current = first;
            while (current != null)
            {
                if (current.Value == value)
                {
                    current.Frequency++;
                    return;
                }

                current = current.Next;
                count++;
            }

            PushFront(value);
        }

        /// <summary>
        /// Return frequency of element.
        /// </summary>
        /// <param name="index"> Index returned element. </param>
        /// <returns></returns>
        public int ReturnFrequencyOfElement(int index)
        {
            if (index < 0 || index > Count || first == null)
            {
                return 0;
            }
            else
            {
                current = first;
                int count = 0;

                while (current != null)
                {
                    if (count == index)
                        return current.Frequency;
                    count++;
                    current = current.Next;
                }

                return current.Frequency;
            }
        }

        /// <summary>
        /// Find element in the list.
        /// </summary>
        /// <param name="element"> Found element. </param>
        /// <returns></returns>
        public bool FindElementInList(object element)
        {
            current = first;

            while (current != null)
            {
                if (current.Value == element)
                    return true;

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Delete element in the list. (if list have several equal elements then deleted first)
        /// </summary>
        /// <param name="element"> Index of deleted element. </param>
        public void DeleteElementInList(int index)
        {
            if (index < 0 || index > Count || first == null)
            {
                return;
            }
            else if (index == 0)
            {
                first = first.Next;
                Count--;

                return;
            }
            else
            {
                current = first;
                int count = 0;

                while (current != null)
                {
                    if (count + 1 == index)
                    {
                        current.Next = current.Next.Next;
                        return;
                    }

                    count++;
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Delete all elements in list.
        /// </summary>
        public void ClearList()
        {
            first = null;
            Count = 0;
        }

        /// <summary>
        /// Test list for empty. (if list is empty then return true)
        /// </summary>
        /// <returns></returns>
        public bool TestForEmpty()
        {
            return Count == 0;
        }

        /// <summary>
        /// Return size of list.
        /// </summary>
        /// <returns></returns>
        public int SizeOfList()
        {
            return Count;
        }

        /// <summary>
        /// Property for size.
        /// </summary>
        public int Count { get; set; }

        private class ListElement
        {
            private ListElement next;
            int frequency = 1;

            public object Value { get; set; }

            public ListElement(object element)
            {
                this.Value = element;
            }

            /// <summary>
            /// Next element of the list.
            /// </summary>
            public ListElement Next
            {
                get { return this.next; }
                set { this.next = value; }
            }

            /// <summary>
            /// Frequency of a list item.
            /// </summary>
            public int Frequency
            {
                get { return frequency; }
                set { frequency = value; }
            }
        }
    }
}
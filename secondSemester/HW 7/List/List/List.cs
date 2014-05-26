namespace List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Class of list.
    /// </summary>
    /// <typeparam name="T"> Type of element. </typeparam>
    public class List<T> : IEnumerable<T>
    {
        private ListElement First { get; set; }
        private ListElement Current { get; set; }
        public int Count { get; set; }

        /// <summary>
        /// Method for add element in front of list.
        /// </summary>
        /// <param name="value"></param>
        public void PushFront(T value)
        {
            ListElement newElement = new ListElement(value);

            newElement.Next = First;
            First = newElement;

            Count++;
        }

        /// <summary>
        /// Method for add element in back of list.
        /// </summary>
        /// <param name="value"></param>
        public void PushBack(T value)
        {
            ListElement newElement = new ListElement(value);

            if (First == null)
                First = newElement;
            else
            {
                Current = First;

                while (Current.Next != null)
                    Current = Current.Next;

                Current.Next = newElement;
                Current.Next.Next = null;
            }

            Count++;
        }

        /// <summary>
        /// Method for add element to the desired position of list.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="value"></param>
        public void Insert(T value, int index)
        {
            if (index < 0 || index > Count)
            {
                return;
            }
            else if (index == 0)
            {
                PushFront(value);
            }
            else if (index == Count)
            {
                PushBack(value);
            }
            else
            {
                int count = 0;
                Current = First;
                while (Current != null && count != index - 1)
                {
                    Current = Current.Next;
                    count++;
                }

                ListElement newElement = new ListElement(value);
                newElement.Next = Current.Next;
                Current.Next = newElement;
                Count++;
            }
        }

        /// <summary>
        /// Method for search element in list;
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SearchElement(T value)
        {
            for (ListElement temp = First; temp != null; temp = temp.Next)
            {
                if (Equals(temp.Value, value))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Method for clear list.
        /// </summary>
        public void Clear()
        {
            First = null;
            Count = 0;
        }

        /// <summary>
        /// Method for write list.
        /// </summary>
        /// <returns></returns>
        public void OutPutList()
        {
            if (First == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            Current = First;
            while (Current != null)
            {
                Console.Write("{0} ", Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method for testing list of empty.
        /// </summary>
        /// <returns></returns>
        public bool TestForEmpty()
        {
            return First == null;
        }
        
        /// <summary>
        /// Return value of element.
        /// </summary>
        /// <param name="index"> Index returned element. </param>
        /// <returns></returns>
        public object ReturnValueOfElement(int index)
        {
            if (index < 0 || index > Count || First == null)
                return null;
            else
            {
                Current = First;
                int count = 0;

                while (Current != null)
                {
                    if (count == index)
                        return Current.Value;
                    count++;
                    Current = Current.Next;
                }

                return Current.Value;
            }
        }

        /// <summary>
        /// List enumerator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class ListEnumerator : IEnumerator<T>
        {
            private ListElement curElement;
            private int curIndex;
            private List<T> curCollection;

            /// <summary>
            /// Return current value.
            /// </summary>
            public T Current { get { return curElement.Value; } }

            object IEnumerator.Current { get { return Current; } }

            void IDisposable.Dispose() { }

            public ListEnumerator(List<T> list)
            {
                curElement = new ListElement(default(T));
                curElement.Next = list.First;
                curIndex = -1;
                curCollection = list;
            }

            /// <summary>
            /// Move enumenator for next element and check end of list.
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (++curIndex >= curCollection.Count)
                    return false;
                else
                    curElement = curElement.Next;

                return true;
            }

            /// <summary>
            /// Sets initial value.
            /// </summary>
            public void Reset()
            {
                curIndex = -1;
                curElement = new ListElement(default(T));
                curElement.Next = curCollection.First;
            }
        }

        /// <summary>
        /// Return ListEnumerator for this list..
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator(this);
        }

        /// <summary>
        /// GetEnumerator
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Class of list element.
        /// </summary>
        private class ListElement
        {
            public ListElement(T value)
            {
                Value = value;
            }

            public T Value { get; set; }
            public ListElement Next { get; set; }
            public ListElement Back { get; set; } 
        }
    }
}
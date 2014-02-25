using System;

namespace Homework_2
{
    public static class StackAsClass
    {
        public static void Main()
        {
            object a;
            a = 1;

            Stack stack = new Stack();

            stack.Push(a);
            stack.Push("ror");

            Console.WriteLine("{0}", stack.Top().Value);

            stack.Pop();

            Console.WriteLine("{0}", stack.Top().Value);
        }

        public class ListElement
        {
            private object data;
            private ListElement next;

            public object Value
            {
                get {
                        if (this != null)
                        {
                            return data;
                        }

                        return 0;
                    }

                set {
                        data = value; 
                    }
            }

            public ListElement(object element)
            {
                this.data = element;
            }

            public ListElement Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }

        public class Stack
        {
            private ListElement first;
            private ListElement current;
            private ListElement last;
            private int size;

            public Stack()
            {
                size = 0;
                first = current = last = null;
            }

            public void Push(object value)
            {
                ListElement newElement = new ListElement(value);

                newElement.Next = first;
                first = newElement;

                Count++;
            }

            public ListElement Top()
            {
                if (first == null)
                {
                    ListElement temp = new ListElement(null);
                    return temp;
                }
                else
                {
                    ListElement temp = first;
                    return temp;
                }
            }

            public ListElement Pop()
            {
                if (first == null)
                {
                    ListElement temp = new ListElement(null);
                    return temp;
                }
                else
                {
                    ListElement temp = first;
                    first = first.Next;

                    Count--;

                    return temp;
                }
            }




            public bool testForEmpty()
            {
                return size == 0;
            }

            public int Count //свойство для size
            {
                get { return size; }
                set { size = value; }
            }
        }
    }
}

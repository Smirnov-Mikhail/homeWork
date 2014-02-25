public class Stack
{
    private StackElement first;
    private int size;

    public Stack()
    {
        size = 0;
        first = null;
    }

    // add element in start of stack
    public void Push(object value)
    {
        StackElement newElement = new StackElement(value);

        newElement.Next = first;
        first = newElement;

        Count++;
    }

    // return first element
    public StackElement Top()
    {
        if (first == null)
        {
            StackElement temp = new StackElement(null);
            return temp;
        }
        else
        {
            StackElement temp = first;
            return temp;
        }
    }

    // delete first element and return its
    public StackElement Pop()
    {
        if (first == null)
        {
            StackElement temp = new StackElement(null);
            return temp;
        }
        else
        {
            StackElement temp = first;
            first = first.Next;

            Count--;

            return temp;
        }
    }

    // delete all elements in stack
    public void ClearStack()
    {
        StackElement temp = first;
        while (temp != null)
            temp = temp.Next;
    }

    public bool TestForEmpty()
    {
        return size == 0;
    }

    //property for size
    public int Count 
    {
        get { return size; }
        set { size = value; }
    }
}
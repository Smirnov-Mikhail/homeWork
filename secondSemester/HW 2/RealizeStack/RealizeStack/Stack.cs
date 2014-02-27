public class Stack
{
    private StackElement first;
    private int size;

    public Stack()
    {
        size = 0;
        first = null;
    }

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
    /// Return first element
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// Delete first element and return its.
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// Delete all elements in stack.
    /// </summary>
    public void ClearStack()
    {
        StackElement temp = first;
        while (temp != null)
            temp = temp.Next;

        size = 0;
    }

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
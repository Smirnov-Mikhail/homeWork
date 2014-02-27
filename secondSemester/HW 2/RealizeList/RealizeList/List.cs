using System;

public class List
{
    private ListElement first;
    private ListElement current;
    private ListElement last;
    private int size;

    public List()
    {
        size = 0;
        first = current = last = null;
    }

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
            first = last = newElement;
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
    public void Insert_Index(object value, int index)
    {
        if (index < 1 || index > size)
        {
            return;
        }
        else if (index == 1) // if inserted to the front
        {
            PushFront(value);
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
    /// Show on the display elements of list
    /// </summary>
    public void OutPutList()
    {
        if (first == null)
        {
            Console.WriteLine("List is empty!");
            return;
        }
        current = first;
        int count = 1;
        while (current != null)
        {
            Console.Write("{0} ", current.Value);
            count++;
            current = current.Next;
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Return value of element.
    /// </summary>
    /// <param name="index"> Index returned element. </param>
    /// <returns></returns>
    public ListElement ReturnValueOfElement(int index)
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

    // delete all elements in List
    public void ClearList()
    {
        ListElement temp = first;
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
        get { 
                return size; 
            }
        set { 
                size = value; 
            }
    }
}
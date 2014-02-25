public class StackElement
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

    public StackElement Next
    {
        get { return this.next; }
        set { this.next = value; }
    }
}
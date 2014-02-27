public class ListElement
{
    private object data;
    private ListElement next;

    public object Value
    {
        get { 
                return data; 
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
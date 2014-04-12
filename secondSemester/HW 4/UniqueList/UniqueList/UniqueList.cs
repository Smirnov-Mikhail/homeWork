namespace UniqueList
{
    using System;
    using ListNamespace;

    public class UniqueList : List
    {
        /// <summary>
        /// Add element in front of list (without repeat).
        /// </summary>
        /// <param name="value"> Added element. </param>
        public void PushFront(object value)
        {
            if (FindElementInList(value))
                throw new RepeatException();
            else
                base.PushFront(value);
        }

        /// <summary>
        /// Add element in back of list (without repeat).
        /// </summary>
        /// <param name="value"> Added element. </param>
        public void PushBack(object value)
        {
            if (this.FindElementInList(value))
                throw new RepeatException();
            else
                base.PushBack(value);
        }

        /// <summary>
        /// Add element to the desired position of list (without repeat).
        /// </summary>
        /// <param name="newElement"> Added element. </param>
        /// <param name="index"> Index of desired position. (if index does not satisfy then the method does nothing) </param>
        public void InsertIndex(object value, int index)
        {
            if (this.FindElementInList(value))
                throw new RepeatException();
            else
                base.InsertIndex(value, index);
        }

        /// <summary>
        /// Delete element in the list.
        /// </summary>
        /// <param name="element"> Index of deleted element. </param>
        public void DeleteElementInList(int index)
        {

            if (index < 0 || index >= Count)
                throw new DeletedNonExistent();
            else
                base.DeleteElementInList(index);
        }
    }
}

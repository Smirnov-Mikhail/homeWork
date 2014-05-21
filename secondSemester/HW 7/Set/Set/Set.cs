namespace SetNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class of set.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Set<T> where T : IComparable
    {
        private List<T> list = new List<T>();

        /// <summary>
        /// Method for add element.
        /// </summary>
        /// <param name="value"> Added element. </param>
        public void Add(T value)
        {       
            if (!SearchElement(value))
                list.Add(value);
        }

        /// <summary>
        /// Method for delete element.
        /// </summary>
        /// <param name="value"> Deleted element. </param>
        public void Delete(T value)
        {
            list.Remove(value);
        }

        /// <summary>
        /// Methos for search element.
        /// </summary>
        /// <param name="value"> Searched element. </param>
        /// <returns></returns>
        public bool SearchElement(T value)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].CompareTo(value) == 0)
                    return true;

            return false;
        }

        /// <summary>
        /// Method for intersection of two sets.
        /// </summary>
        /// <param name="set"> Second set. </param>
        public void Intersection(Set<T> set)
        {
            for (int i = 0; i < list.Count; i++)
                set.Delete(list[i]);
        }

        /// <summary>
        /// Method for union of two sets.
        /// </summary>
        /// <param name="set"> Second set. </param>
        public void Union(Set<T> set)
        {
            for (int i = 0; i < list.Count; i++)
                if (!set.SearchElement(list[i]))
                    set.Add(list[i]);
        }

        /// <summary>
        /// Method for test set on empty.
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return list.Count == 0;
        }

        /// <summary>
        /// Method for output set.
        /// </summary>
        public void Write()
        {
            for (int i = 0; i < list.Count; i++)
                Console.Write("{0} ", list[i]);

            Console.WriteLine();
        }
    }
}

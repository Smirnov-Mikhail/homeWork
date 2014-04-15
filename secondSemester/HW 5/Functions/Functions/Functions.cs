namespace Functions
{
    using System;
    using System.Collections.Generic;

    public class Functions<T>
    {
        /// <summary>
        /// Changes to the list of "specific functions".
        /// </summary>
        /// <param name="list"></param>
        /// <param name="function"> This function. </param>
        /// <returns></returns>
        public static List<T> Map(List<T> list, Func<T, T> function)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < list.Count; i++)
                result.Insert(result.Count, function(list[i]));

            return result;
        }

        public static List<T> Filter(List<T> list, Func<T, bool> function)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < list.Count; i++)
            {
                if (function(list[i]))
                    result.Insert(result.Count, list[i]);
            }

            return result;
        }

        public static int Fold(List<T> list, int firstElement, Func<int, T, int> function)
        {
            int result = firstElement;

            for (int i = 0; i < list.Count; i++)
            {
                result = function(result, list[i]);
            }

            return result;
        }
    }
}

﻿

using System.Collections.Generic;

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        // ------------------------ Arrays ---------------------------
        public static T[] RepeatArray<T>(T element, int count)
        {
            var result = new T[count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = element;
            }
            return result;
        }

        // ------------------------ Lists ---------------------------
        public static List<T> RepeatList<T>(T element, int count)
        {
            var result = new List<T>(count);
            for (int i = 0; i < result.Count; i++)
            {
                result.Add(element);
            }
            return result;
        }

    }
}
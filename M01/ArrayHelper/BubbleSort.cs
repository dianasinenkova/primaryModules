using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper
{
    public static class BubbleSort
    {

        public static T[] BubbleSortAsc<T>(this T[] array) where T : IComparable<T>
        {
            if (array.Length > 0)
            {
                T x;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = array.Length-1; j > i; j--)
                    {
                        if (array[j-1].CompareTo(array[j]) > 0)
                        {
                            x = array[j - 1];
                            array[j - 1] = array[j];
                            array[j] = x;
                        }
                    }
                }
            }
            return array;
        }

        public static T[] BubbleSortDesc<T>(this T[] array) where T : IComparable<T>
        {
            T x;
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = array.Length - 1; j > i; j--)
                    {
                        if (array[j-1].CompareTo(array[j]) < 0)
                        {
                            x = array[j - 1];
                            array[j - 1] = array[j];
                            array[j] = x;
                        }
                    }
                }
            }
            return array;
        }

    }
}
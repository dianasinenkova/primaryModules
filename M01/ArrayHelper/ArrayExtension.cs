using System;
using System.Collections.Generic;
using System.Text;

 namespace ArrayHelper
{
    public static class ArrayExtension
    {

        public static T[] BubbleSortAsc<T>(this T[] array) where T : IComparable<T>
        {
            if (array.Length > 0)
            {
                T x;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j].CompareTo(array[j]) > 0)
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
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j].CompareTo(array[j]) < 0)
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

        private static int Calculate(this int[,] array)
        {
            int res = 0;
            if (array.Length > 0)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        if (array[i, j] > 0)
                        {
                            res += array[i, j];
                        }
                    }
                }
            }
            return res;
        }

        private static double Calculate(this double[,] array)
        {
            double res = 0;
            if (array.Length > 0)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        if (array[i, j] > 0)
                        {
                            res += array[i, j];
                        }
                    }
                }
            }
            return res;
        }

        private static sbyte Calculate(this sbyte[,] array)
        {
            sbyte res = 0;
            if (array.Length > 0)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        if (array[i, j] > 0)
                        {
                            res += array[i, j];
                        }
                    }
                }
            }
            return res;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper
{
    public class ArrayExtension
    {

        public static T[] BubbleSortAsc<T>(T[] array) where T : IComparable<T>
        {
            //Тут нужно проверить на ненулевой массив
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
            // а если все ж нулевой массив? 
        }

        public static T[] BubbleSortDesc<T>(T[] array) where T : IComparable<T>
        {
            T x;
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
            return array;
        }

        private static int Calculate(int[,] array)
        {
            int res = 0;
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
            return res;
        }

        private static double Calculate(double[,] array)
        {
            double res = 0;
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
            return res;
        }

        private static sbyte Calculate(sbyte[,] array)
        {
            sbyte res = 0;
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
            return res;
        }


    }
}

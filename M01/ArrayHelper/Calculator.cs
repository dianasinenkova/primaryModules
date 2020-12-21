using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper
{
    public static class Calculator
    {
        public static int Calculate(this int[,] array)
        {
            int res = 0;
            if (array.Length > 0)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
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

        public static double Calculate(this double[,] array)
        {
            double res = 0;
            if (array.Length > 0)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
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

        public static sbyte Calculate(this sbyte[,] array)
        {
            sbyte res = 0;
            if (array.Length > 0)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
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

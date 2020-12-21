using System;
using ArrayHelper;

namespace LibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAYHELPER DEMO
            Console.WriteLine("Демонстрация библиотеки ArrayHelper");

            //BUBBLESORT DEMO
            Console.WriteLine("Для массива типа int");
            int[] arr1 = {45, 24, 56, 48, 2, 58, 39, 19};
            Console.WriteLine("Неотсортированный массив:");
            for (int i=0; i<arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            arr1.BubbleSortAsc();
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив по возрастанию:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            arr1.BubbleSortDesc();
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив по убыванию:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Для массива типа double");
            double[] arr2 = { 39.6, 48.1, 848.56, 59876.45, 1.5687, 1.5976 };
            Console.WriteLine("Неотсортированный массив:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            arr2.BubbleSortAsc();
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив по возрастанию:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            arr2.BubbleSortDesc();
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив по убыванию:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Для массива типа string");
            string[] arr3 = { "abhjfd", "jkusk", "poejc", "qjixbs", "amkcjd", "klkxx" };
            Console.WriteLine("Неотсортированный массив:");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            arr3.BubbleSortAsc();
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив по возрастанию:");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            arr3.BubbleSortDesc();
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив по убыванию:");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();

            //CALCULATE DEMO
            Console.WriteLine("Для двумерного массива типа int");
            Console.WriteLine("Массив: ");
            int[,] arr4 = { {-1586, 23, 114, -198 }, {5, -5689, 81, -12 } };
            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    Console.Write(arr4[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Результат: " + arr4.Calculate());
            Console.WriteLine();

            Console.WriteLine("Для двумерного массива типа double");
            Console.WriteLine("Массив: ");
            int[,] arr5 = { { -1586, 23, 114, -198 }, { 5, -5689, 81, -12 } }; //TODO: сменить числа на double
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    Console.Write(arr5[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Результат: " + arr5.Calculate());
            Console.WriteLine();

            Console.WriteLine("Для двумерного массива типа sbyte");
            Console.WriteLine("Массив: ");
            int[,] arr6 = { { -1586, 23, 114, -198 }, { 5, -5689, 81, -12 } }; //TODO: сменить числа на sbyte
            for (int i = 0; i < arr6.GetLength(0); i++)
            {
                for (int j = 0; j < arr6.GetLength(1); j++)
                {
                    Console.Write(arr6[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Результат: " + arr6.Calculate());
            Console.WriteLine();



            //RECTANGLEHELPER DEMO
            Console.WriteLine();
            Console.WriteLine("Демонстрация библиотеки RectangleHelper");

            Console.WriteLine("Если у вас есть прямоугольник со сторонами ");
        }

    }
}

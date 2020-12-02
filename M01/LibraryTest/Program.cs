using System;
using ArrayHelper;

namespace LibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Демонстрация библиотеки ArrayHelper");
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
            Console.WriteLine("Демонстрация библиотеки RectangleHelper");
        }

    }
}

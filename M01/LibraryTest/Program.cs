using System;
using ArrayHelper;

namespace LibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Работу какой библиотеки продемонстрировать? 1 - ArrayHelper, 2 - LibraryHelper");
                string s = Console.ReadLine();
                int opt = Int32.Parse(s);
                var separators = new Char[] { ' ', ',' };
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Демонстрируется работа библиотеки ArrayHelper");
                        //Console.WriteLine("Введите массив:");
                        Console.WriteLine("Выберите тип массива: 1 - sbyte, 2 - int, 3 - double, 4 - string");
                        string s2 = Console.ReadLine();
                        if (s2 == "1")
                        {
                            Console.WriteLine("Введите массив:");
                            string arr = Console.ReadLine();
                            string[] array = arr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            sbyte[] sbyteArray = new sbyte[array.Length];
                            //bool isParse = false;
                            for (int i = 0; i > array.Length; i++)
                            {
                                sbyteArray[i] = SByte.Parse(array[i]);
                            }
                            sbyteArray.BubbleSortAsc();
                            foreach (sbyte a in sbyteArray)
                            {
                                string res = a.ToString();
                                Console.Write(res + " ");
                            }

                            sbyteArray.BubbleSortDesc();
                            foreach (sbyte a in sbyteArray)
                            {
                                string res = a.ToString();
                                Console.Write(res + " ");
                            }
                        }

                        if (s2 == "2")
                        {
                            Console.WriteLine("Введите массив:");
                            string arr = Console.ReadLine();
                            string[] array = arr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            int[] intArray = new int[array.Length];
                            //bool isParse = false;
                            for (int i = 0; i > array.Length; i++)
                            {
                                intArray[i] = Int32.Parse(array[i]);
                            }
                            intArray.BubbleSortAsc();
                            foreach (int a in intArray)
                            {
                                string res = a.ToString();
                                Console.Write(res + " ");
                            }

                            intArray.BubbleSortDesc();
                            foreach (int a in intArray)
                            {
                                string res = a.ToString();
                                Console.Write(res + " ");
                            }
                        }

                        if (s2 == "3")
                        {
                            Console.WriteLine("Введите массив:");
                            string arr = Console.ReadLine();
                            string[] array = arr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            double[] doubleArray = new double[array.Length];
                            //bool isParse = false;
                            for (int i = 0; i > array.Length; i++)
                            {
                                doubleArray[i] = Double.Parse(array[i]);
                            }
                            doubleArray.BubbleSortAsc();
                            foreach (double a in doubleArray)
                            {
                                string res = a.ToString();
                                Console.Write(res + " ");
                            }

                            doubleArray.BubbleSortDesc();
                            foreach (double a in doubleArray)
                            {
                                string res = a.ToString();
                                Console.Write(res + " ");
                            }
                        }

                        if (s2 == "4")
                        {
                            Console.WriteLine("Введите массив:");
                            string arr = Console.ReadLine();
                            string[] array = arr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            array.BubbleSortAsc();
                            foreach (string a in array)
                            {
                                Console.Write(a + " ");
                            }

                            array.BubbleSortDesc();
                            foreach (string a in array)
                            {
                                Console.Write(a + " ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неправильно введены данные.");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Демонстрируется работа библиотеки RectangleHelper");
                        //как тестировать?
                        break;

                    default:
                        break;

                }
            }
        }
    }
}

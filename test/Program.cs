using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8, y = 2;
            int[] array = {1, -5, 3, 0};

            Console.WriteLine(MinMax(x, y));
            Console.WriteLine("Max from array = " + Max(array));
            Console.WriteLine(EvenCheck(x));
            Console.WriteLine(AllEvenFrom1(x));

            Console.ReadLine();
        }
        

        /// <summary>
        /// два числа на вход  какое большее какое меньшее
        /// </summary>
        /// <returns></returns>
        static string MinMax(int x, int y)
        {
            if (x > y)
            {
                return $"Enter: x = {x}; y = {y}. Max = {x} Min = {y}";
            }
            else
            {
                return $"Enter: x = {x}; y = {y}. Max = {y} Min = {x}";
            }
        }

        /// <summary>
        /// на вход три числа и макс на выход
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int Max(int[] array)
        {
            int x = 0;

            for (int i = 0; i < array.Length;  i++)
            {
                if (i > x)
                {
                    x = i;
                }
            }

            return x;
        }

        /// <summary>
        /// вход число и проверка на четность
        /// </summary>
        /// <returns></returns>
        static string EvenCheck(int x)
        {
            return x % 2 > 0? $"{x} нечетное" : $"{x} четное";
        }

        /// <summary>
        ///  на вход число N, а на выходе все четные числа от 1 до N
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static string AllEvenFrom1(int x)
        {
            string result = null;

            for (int i = 1; i < x; i++)
            {
                
                if (i % 2 == 0)
                    result = result + i.ToString() + " ";
            }
                return $"Четные числа от 1 до {x} = {result}";
        }
    }
}
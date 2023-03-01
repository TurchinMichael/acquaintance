using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 63433, y = 3;

            // Задача 1: есть ли третья цифра в числа?
            if (x.ToString().Length <= 2)
                Console.WriteLine("третьей цифры нет");
           
            Console.WriteLine($"{y} цифра числа {x} = {CheckNumberPosition(x, y)}");

            Console.WriteLine(CheckWeekend(8));

        }

        /// <summary>
        /// Задача 2: принимаем число, выводим цифру числа по заданной позиции
        /// </summary>
        /// <param name="x">проверочная цифра</param>
        /// <param name="y">позиция цифры</param>
        /// <returns></returns>
        static public int CheckNumberPosition(int x, int y)
        {
            try
            {
                return Convert.ToInt32(x.ToString()[y - 1].ToString());
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Задача 3: проверка входящей цифры на то, рабочий это день, выходной, или не день недели вовсе
        /// </summary>
        /// <param name="day">проверяемый день</param>
        /// <returns>рабочий день, не рабочий, или не день недели</returns>
        static string CheckWeekend (int day)
        {
            return day < 8 ? day > 5 ? "weekend" : "work day" : "not a week day";  // return x % 2 > 0? $"{x} нечетное" : $"{x} четное";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._3_RecursionEcho
{
    internal class Program
    {
        #region 5.5.3 - 5.5.4 Рекурсия имитации эха и окрашивание фона текста консоли

        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то (не менее 2 символов): ");
            string str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха: ");
            int deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.ReadKey();
        }

        static void Echo(string str, int deep)
        {
            var strModif = str;
            if (strModif.Length > 2)
            {
                strModif = strModif.Remove(0, 2);

                Console.BackgroundColor = (ConsoleColor)deep;
                Console.WriteLine("..." + strModif);

                if (deep > 1)
                {
                    Echo(strModif, deep - 1);
                }
            }
        }

        #endregion

        #region 5.5.5 - 5.5.7 Факториал

        //static void Main(string[] args)
        //{
        //    Console.Write("Введите целое положительное число: ");
        //    int x = int.Parse(Console.ReadLine());

        //    Console.WriteLine($"Факториал введенного числа: {Factorial(x)}");

        //    Console.ReadKey();
        //}

        //static decimal Factorial(int x)
        //{
        //    if (x == 0) return 1;
        //    else return x * Factorial(x - 1);
        //}

        #endregion

        #region 5.5.8 Возведение в степень

        //public static void Main(string[] args)
        //{
        //    Console.Write("Введите целое число для возведения в степень: ");
        //    int n = int.Parse(Console.ReadLine());

        //    Console.Write("Введите целое число степени: ");
        //    byte pow = byte.Parse(Console.ReadLine());

        //    Console.WriteLine($"Полученный результат: {Exponentiation(n, pow)}");

        //    Console.ReadKey();
        //}

        //public static decimal Exponentiation(int n, byte pow)
        //{
        //    if (pow == 0) return 1;
        //    else if (pow == 1) return n;
        //    else return n * Exponentiation(n, --pow);
        //}

        #endregion


    }
}

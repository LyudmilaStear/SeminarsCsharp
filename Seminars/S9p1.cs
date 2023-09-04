using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S9p1
    {
        /// <summary>
        /// рекурсии
        /// </summary>
        public static void Launch()
        {
            //Задача 63: Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
            //N = 5-> "1, 2, 3, 4, 5"
            //N = 6-> "1, 2, 3, 4, 5, 6"

            //не получилось
            //string PrintNumber (int num)
            //{
            //    while (num >= 0)
            //    {
            //        //return PrintNumber(num);
            //        Console.WriteLine(PrintNumber(num));
            //        num = num - 1;
            //    }
            //}

            //Console.WriteLine("input number: ");
            //int userNum = Convert.ToInt32(Console.ReadLine());
            //PrintNumber (userNum);

            /*
            string PrintNumer(int num, string res)
            {
                if (num == 1)
                {
                    res = "1" + res;
                    return res;
                }
                else
                {
                    res = ", " + num + res;
                    return PrintNumer(num - 1, res);
                }
            }
            string result = "";

            Console.Write("Input the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            result = PrintNumer(number, result);
            Console.WriteLine(result);
            */


            //вар 2
            /*
            string PrintNumbers(int start, int end)
            {               
                if (start == end) return start.ToString();
                return (start + ", " + PrintNumbers(start + 1, end));
            }
            Console.Write("Input the last(max) number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the first(min) number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(PrintNumbers(start, number));
            */

            //Задача 65: Задайте значения M и N.Напишите программу, которая выведет все натуральные числа
            //в промежутке от M до N.
            //M = 1; N = 5-> "1, 2, 3, 4, 5"
            //M = 4; N = 8-> "4, 6, 7, 8"

            //
            /*
            string PrintNumbers(int start, int end)
            {

                if (start == end) return start.ToString();
                return (start + ", " + PrintNumbers(start + 1, end));
            }
            Console.Write("Input the last(max) number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the first(min) number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(PrintNumbers(start, number)); 
            */

            // не поняла как работает
            /*
            void ShowNaturalNumbers(int min, int max, int count = 0)
            {
                if (min > count) count = min;
                else count++;
                Console.Write(count + ", ");
                if (count < max)
                {
                    ShowNaturalNumbers(min, max, count);
                }
            }
            Console.Write("Input a min: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a max: ");
            int max = Convert.ToInt32(Console.ReadLine());
            ShowNaturalNumbers(min, max);
            */



            //Задача 69: Напишите программу, которая на вход принимает два числа A и B,
            //и возводит число А в целую степень B с помощью рекурсии.
            //A = 3; B = 5-> 243(3⁵)
            //A = 2; B = 3-> 8

            /*
            int NumAPowerInNumB (int numA, int numB)
            {
                if (numB == 0)
                    return 1;
                else
                {
                    return numA * NumAPowerInNumB(numA, numB - 1);
                }               
            }

            Console.Write("Input numA: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input stepen of numA: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = NumAPowerInNumB(a, b);
            Console.WriteLine(result);
            */

            //Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
            //453-> 12
            //45-> 9
            //Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
            //A = 3; B = 5-> 243(3⁵)
            //A = 2; B = 3-> 8

            /*
            int SumOfDigits(int num)
            {
                if (num < 10)
                {
                    return num;
                }
                else
                {
                    return num % 10 + SumOfDigits(num / 10);
                }
            }
            Console.Write("Input num: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int res = SumOfDigits(a);
            Console.WriteLine(res);
            */
        }
    }
}

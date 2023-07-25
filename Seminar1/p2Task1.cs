using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminar1
{
    public static  class p2Task1
    {
        public static void launch()
        {
            //Task 1
            //Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

            Console.WriteLine("Input a number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int quad2 = number2 * number2;

            if (number1 == quad2)
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }

            /*Алльтернативное написание "если", без фигурных скобок. ТОЛЬКо если в скобках только ОДНА команда
             if(number1 == quad2)
             Console.WriteLine("Yes!");
            else
            Console.WriteLine("No!");
            */
        }
    }
}

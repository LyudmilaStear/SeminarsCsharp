using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminar1
{
    public static class p2Task2
    {
        public static void Launch()
        {
            //Task 2
            //Напишите программу, которая на вход принимает одно положительное число (N), а на выходе показывает все целые числа в промежутке от -N до N.

            Console.WriteLine("input a positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int current = -num;

            while (current <= num)
            {
                Console.Write(current + " ");
                current++;
            }
        }
    }
}

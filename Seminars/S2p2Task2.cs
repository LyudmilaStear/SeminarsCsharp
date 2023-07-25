using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S2p2Task2
    {
        public static void Launch()
        {
            //Task 2

            //Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.


            bool IsDivisible(int num, int div1, int div2)
            {
                // if (num % div1 == 0 && num % div2 ==0)
                //   return true; 
                // else
                //return false;

                return num % div1 == 0 && num % div2 == 0;
            }
            Console.Write("Input a number for checking: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the first divider: ");
            int divider1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second divider: ");
            int divider2 = Convert.ToInt32(Console.ReadLine());

            bool res = IsDivisible(number, divider1, divider2);

            if (res) Console.Write("Yes!");
            else Console.Write("No!");
        }
    }
}

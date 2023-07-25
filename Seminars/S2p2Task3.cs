using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S2p2Task3
    {
        public static void Launch()
        {
            //Task 3

            //Напишите программу, которая выводит случайное 
            //число из отрезка[10, 99] и показывает наибольшую цифру
            //числа.


            int MaxNum(int number)
            {
                int a = number / 10;
                int b = number % 10;
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
                int num = new Random().Next(10, 100);
                Console.WriteLine(num);
                int res = MaxNum(num);
                Console.WriteLine($"Number is {num}, the biggest unit is {MaxNum(num)}");

            /* int MaxNum(int num)
             { 
                   int a = number / 10;
                int b = number % 10;
                if (a > b) return a;
                else return b;
            } 


             }
            */
        }
    }

}

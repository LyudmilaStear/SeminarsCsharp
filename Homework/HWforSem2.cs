using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Homework
{
    public static class HWforSem2
    {
        public static void Launch()
        {
            //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            //456-> 5
            //782-> 8
            //918-> 1

            /*int MiddleUnit(int num)
            {
                   int a = num / 10;
                   int b = a % 10;
                   return b;
            }

           Console.WriteLine("Insert any three-digit number: ");         
           int numb = Convert.ToInt32(Console.ReadLine());

           //То же с рандомным числом:
           //int numb = new Random().Next(100, 1000);
           //Console.WriteLine(numb);
           //Console.WriteLine("The middle digit is " + MiddleUnit(numb));
           */


            //Задача 13: Напишите программу, которая выводит третью цифру заданного числа(или - 1, если третьей цифры нет).
            //645-> 5
            //78->третьей цифры нет
            //32679-> 6

            /*int ThirdDidit(int num)
            {
                if (num > 99)
                {
                    while (num > 999)
                    {
                        num = num / 10;
                    }
                    int b = num % 10;
                    return b;
                }
                else
                {
                    return -1;
                }
            }
            Console.WriteLine("Insert any number: ");
            int numb = Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine(ThirdDidit(numb));
            */

            //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            //6->да
            //7->да
            //1->нет

            /*Console.WriteLine("Insert the week's day number: "); // int numb = new random.Next(1, 8);
            int numb = Convert.ToInt32(Console.ReadLine());

            if (numb > 0 && numb < 8)
            {
                if (numb == 6 || numb == 7)
                {
                    Console.WriteLine("Yes! It is weekend).");
                }
                else
                {
                    Console.WriteLine("No! It's not the weekend((.");
                }
            }
            else Console.WriteLine("The wrong number!");
            */
        }

    }
}

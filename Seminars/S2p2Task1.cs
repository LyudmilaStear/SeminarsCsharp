using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S2p2Task1
    {
        public static void Launch()
        {
            //Task 1

            //Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

            int CutNumber(int num)
            {
                int hundreds = num / 100;
                int units = num % 10;

                int res = hundreds * 10 + units; // иначе return = hundreds * 10 + units
                return res; //эта команда возвращает в основной код искомую переменную

            }

            int randNum = new Random().Next(100, 1000);
            int cuttedNum = CutNumber(randNum);
            Console.WriteLine($"New version of {randNum} is {cuttedNum}");

            /* another way
             CutNumber(randNum);
            Console.WriteLine(cutNumber(randNum));
            */
            //351 -> 3 1 --> 31
        }
    }
}

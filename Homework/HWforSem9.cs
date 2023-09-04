using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Homework
{
    public static class HWforSem9
    {
        public static void Launch()
        {
            //Задача 64: Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.
            //N = 5-> "5, 4, 3, 2, 1"
            //N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"
            /*
            string PrintNumer(int num, string res)
            {
                if (num == 1)
                {
                    res = res + "1";
                    return res;
                }
                else
                {
                    res = res + num + ", ";
                    return PrintNumer(num - 1, res);
                }
            }
            string result = "";

            Console.Write("Input the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            result = PrintNumer(number, result);
            Console.WriteLine(result);
            */

            //Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            //M = 1; N = 15-> 120
            //M = 4; N = 8. -> 30

            /*
            int SumOfElements(int numA, int numB)
            {
                if (numA == numB)
                {
                    return numA;
                }
                else
                {
                    return numA + SumOfElements(++numA, numB);
                }
            }

            Console.Write("Input the min number: ");
            int minNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the max number: ");
            int maxNumber = Convert.ToInt32(Console.ReadLine());

            if (maxNumber < minNumber)
            {
                int temp = minNumber;
                minNumber = maxNumber;
                maxNumber = temp;
            }           

            int sum = SumOfElements(minNumber, maxNumber);
            Console.WriteLine(sum);
            */


            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            //m = 2, n = 3->A(m, n) = 9
            //m = 3, n = 2->A(m, n) = 29

            int AccermanFunc(int a, int b)
            {

            }

        }
    }
}

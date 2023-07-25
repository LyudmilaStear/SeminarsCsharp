using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S2p2Task4
    {
        public static void Launch()
        {
            //Task 4

            //Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

            //Работает1
            
            bool CheckSquare(int num1, int num2)
            {
                return (num1 == num2 * num2 || num2 == num1 * num1);
            }

            Console.Write("Input a number1 for checking: ");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a number2 for checking: ");
            int numb2 = Convert.ToInt32(Console.ReadLine());

            bool res = CheckSquare(numb1, numb2);

            if (res) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            


            //Менее оптимальный вариант

            /*Console.Write("Input a number1 for checking: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a number2 for checking: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sqNum1 = num2 * num2;
            int sqNum2 = num1 * num1;

            if (num1 == sqNum1) 
            {
                Console.WriteLine("Number1 is a sqare of Number2");
            }
            else
            {
                if (num2 == sqNum2)
                {
                    Console.WriteLine("Number2 is a sqare of Number1");
                }
                else
                {
                    Console.WriteLine("Tey are not a square of each other");
                }
            }
            */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Homework
{
    public static class HWforSem1
    {
        public static void Launch()
        {
            //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            //a = 5; b = 7->max = 7
            //a = 2 b = 10->max = 10
            //a = -9 b = -3->max = -3

            /*Console.WriteLine("Insert tne number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insertt the Number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2) Console.WriteLine($"{num1} is bigger then {num2}");
            else Console.WriteLine($"{num2} is bigger then {num1}");
            */

            //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            //2, 3, 7-> 7
            //44 5 78-> 78
            //22 3 9-> 22

            /*int MaxNumber (int num1, int num2, int num3)
            {
                int maxNum = num1;
                if (num2 > maxNum)
                {
                    maxNum = num2;
                }
                if (num3 > maxNum)
                {
                    maxNum = num3;
                }
                else maxNum = num1;
               
                return maxNum;
            }
            
            Console.WriteLine("Insert tne number1: ");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insertt the Number2: ");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insertt the Number3: ");
            int numb3 = Convert.ToInt32(Console.ReadLine());

            int maxNumb = MaxNumber(numb1, numb2, numb3);
            Console.WriteLine($"The maxx number is {maxNumb}");
            */

            //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным(делится ли оно на два без остатка).
            //4->да
            //- 3->нет
            //7->нет

            /*Console.WriteLine("Insert tne number: ");
            int num = Convert.ToInt32(Console.ReadLine());
           
            if (num % 2 == 0) Console.WriteLine($"The number {num} is even.");
            else Console.WriteLine($"The number {num} isn't even");
            */

            //Задача 8: Напишите программу, которая на вход принимает число(N), а на выходе показывает все чётные числа от 1 до N.
            //5-> 2, 4
            //8-> 2, 4, 6, 8

            /*Console.WriteLine("Inserrt any positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int current = 1;
            while (current <= num)
            {
                if(current % 2 == 0) Console.Write(current + " ");
                current++;
            }
            */

            //Второй варииант решения

            /*Console.WriteLine("Inserrt any positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int current = 2;
            while (current <= num)
            {
                Console.Write(current + " ");
                current = current +2;
            }
            */
        }
    }
}

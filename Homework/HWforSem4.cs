using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Homework
{
    public static class HWforSem4
    {
        
        public static void Launch()
        {
            //====int num1 = 9;
            //int num2 = 10;
            //Console.WriteLine("My numbers are " + num1 + " and " + num2 + " and it is good!");
            //Console.WriteLine($"My numbers are {num1} and {num2} and it is good!");

            /*Деления:
                Целочисленное -- т е без остатка. int
                Остаток от деления - % int
                деление с дробями. double
                

            Целочислеенные деления:
                13259 / 10 = 1325 
                13259 / 100 = 132
                13259 / 1000 = 13
                13259 / 10000 = 1
            

            остаток от деления
            13254 % 10 = 4
            13254 % 100 = 54
            13254 % 1000 = 254
            132

            Math.Pow(5-основание степени, 2- сама степень)
            Math.Sqrt(25-аргумент, из которого находдится квадратный корень); и выддает ответ double.
            Math.Round(Math.Sqrt(24) то что округляем, 2 - степень точчности(колво знаков после запятой));
            */

            //==== Задача 25: Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.
            //3, 5-> 243(3⁵)
            //2, 4-> 16

            /* int PoverNumAInB(int a, int b)
            {
                int result = 1; 
                for (int i = 1; i <= b; i++) //i начинаю с 1, чтобы кол-во циклов совпадало со степенью. Если начать с 0, тогда условие будет i < b.
                {
                    result = result * a;
                }
                return result;
            }
            Console.WriteLine("Введите число, A которое будете возводить в степень: ");
            int base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение натуральной степени B: ");
            int pow1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("A в степени B равно " + PoverNumAInB(base1, pow1));
            */

            //var2.
             
            /*void  PoverNumAInB (int a, int b)
            {
                if (b > 0)
                {
                    int result = Convert.ToInt32(Math.Pow(a, b));
                    Console.WriteLine(result);
                }
                else Console.WriteLine("Wrong meaning of " + b);
            }
            Console.WriteLine("Введите число, которое будете возводить в степень: ");
            int base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение натуральной степени: ");
            int pow1 = Convert.ToInt32(Console.ReadLine());

            PoverNumAInB(base1, pow1);
            */
            

            //==== Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            //452-> 11
            //82-> 10
            //9012-> 12

            /* int SumDigits (int num)
            {          
                int result = 0;
                for (int i = 0; num > 0; i++)
                {
                    result = result + num % 10;
                    num = num / 10;
                }
                return result;
            }
            */

            /* Не работает. Не разобралась пока как строка массив, и индексы и их сложение здесь работает.
             */ 
             /*int SumDigits(string num)
            {
                //int[] num = { num1 }; 
                int length = num.Length;
                int result = 0;
                for (int i = 0; i < length; i++)
                {
                    result = result + num[i];
                }
                return result;
            }

            Console.WriteLine("Введите число: ");
            string numb = Console.ReadLine();
            int sum = SumDigits (numb);
            Console.WriteLine(sum);*/
            

            //==== Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
            //1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
            //6, 1, 33-> [6, 1, 33]

            /* int[] CreateRandomArray(int m, int minValue, int maxValue)
            {
                int[] array = new int[m]; //выделение памяти: тип(инт), название и new int[размер массива]. инициализвция рабочей переменной, существующей только внутри цикла. в случае с массивами - это переменная индекса. 
                for (int i = 0; i < m; i++) // Первый блок может и отсутствовать, НО! его точку с запятой в начале оставляем.
                {
                    array[i] = new Random().Next(minValue, maxValue + 1);                           //второй блок - это логическое условие существования цикла(то что в while пишем обычно. 
                }                           // Третий блок - это процесс направленный на изменение рабочей пременной. Блоки можно расширять через запятую.
                return array;
            }

            void WriteArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[] userArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(userArray); 
            */


            //генерируем одномерный массив. методы.

            //пользователь вводит данные.

            /* int[] EnterNewArray(int size) //, int minValue, int maxValue)
            {

                int[] array = new int[size]; //выделение памяти: тип(инт), название и new int[размер массива]. инициализвция рабочей переменной, существующей только внутри цикла. в случае с массивами - это переменная индекса. 
                for (int i = 0; i < size; i++) // Первый блок может и отсутствовать, НО! его точку с запятой в начале оставляем.
                {
                    Console.WriteLine($"Введите элемент массива под индексом {i}: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());                           //второй блок - это логическое условие существования цикла(то что в while пишем обычно. 
                }                           // Третий блок - это процесс направленный на изменение рабочей пременной. Блоки можно расширять через запятую.
                return array;
            }

            void WriteArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите размер массива: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] array = EnterNewArray(size1);
            WriteArray(array);
            */
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S4p1
    {
        public static void Launch()
        {
            // Task1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

            /*int Sum (int num)
            {
                int i = 2;
                int sum = 1;
                while (i <= num)
                {
                    sum = sum + i;
                    i++;
                }
                return sum;
            }
            Console.WriteLine("Введите число: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(numb));
            */

            //Task2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

            /*int AmountOfDigits (int num)
            {
                int count = 0;
                while (num > 0)
                {
                    num = num / 10;
                    count++;
                }
                return count;
            }
            Console.WriteLine("Введите число: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AmountOfDigits(numb));
            */

            //Task3. Напишите программу, которая принимает на вход число N и выдаёт произведение нечетных чисел от 1 до N.

            /*int MultiplyOdd (int num)
            {
                int x = 3;
                int mul = 1;
                while (x <= num)
                {
                    mul = mul * x; //mul *= x
                    x = x + 2; //x += 2
                }
                return mul;
            }
            
            Console.WriteLine("Введите число: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MultiplyOdd(numb));
            */

            /* код кирилла с семинара  int Prov(int a)
            {
                int result = 1;
                for (int i = 1; i <= a; i = i + 2)
                    result *= i;
                return result;
            }
            Console.WriteLine("Enter a number: ");
            int nunumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Prov(nunumber));
            */



            //МАССИВЫ
            //генерируем одномерный массив. методы.

            //вар.1. пользователь вводит данные.

            int[] EnterNewArray(int size) //, int minValue, int maxValue)
            {
                
                int[] array = new int[size]; 
                for (int i = 0; i < size; i++) 
                {
                    Console.WriteLine($"Введите элемент массива под индексом {i}");
                    array[i] = Convert.ToInt32(Console.ReadLine());     
                }                           
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

            //вар.2. Генерация рандомными числами.

            /*int[] CreateRandomArray(int size, int minValue, int maxValue)
            {
                int[] array = new int[size]; //выделение памяти: тип(инт), название и new int[размер массива]. 
                for(int i = 0, i < size, i++) // Первый блок. инициализвция рабочей переменной, существующей только внутри цикла. в случае с массивами - это переменная индекса. Первый блок  может и отсутствовать, НО! его точку с запятой в начале оставляем.
                {
                    array[i] = new Random().Next(minValue, maxValue + 1);                           //второй блок - это логическое условие существования цикла(то что в while пишем обычно. 
                }                           // Третий блок - это процесс направленный на изменение рабочей пременной. Блоки можно расширять через запятую.
                return array;
            }
            
            //Вывод массива.

            void WriteArray(int[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            */

            /*int[] CreateRandomArray(int size, int minValue, int maxValue)
            {
                int[] array = new int[size]; //выделение памяти: тип(инт), название и new int[размер массива]. инициализвция рабочей переменной, существующей только внутри цикла. в случае с массивами - это переменная индекса. 
                for(int i = 0; i < size; i++) // Первый блок может и отсутствовать, НО! его точку с запятой в начале оставляем.
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

            int[] myArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(myArray);
            */
        }
    }
}

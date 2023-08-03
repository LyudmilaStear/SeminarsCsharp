using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S5p2
    {
        public static void Launch()
        {
            //===Task1.  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
            
            /*
             int[] CreateRandomArray(int size, int minValue, int maxValue)
            {
                int[] array = new int[size]; //выделение памяти: тип(инт), название и new int[размер массива]. инициализвция рабочей переменной, существующей только внутри цикла. в случае с массивами - это переменная индекса. 
                for (int i = 0; i < size; i++) // Первый блок может и отсутствовать, НО! его точку с запятой в начале оставляем.
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

            int[] Reverse1 (int[] array)
            {
                for ( int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i] * -1; //array[i] *= -1
                }
                return array;
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[] myArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(myArray);
            int[] arrayRev = (Reverse1(myArray));
            WriteArray(arrayRev);
            */

            //===Task2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

            /*
             int[] CreateRandomArray(int size, int minValue, int maxValue)
            {
                int[] array = new int[size]; //выделение памяти: тип(инт), название и new int[размер массива]. инициализвция рабочей переменной, существующей только внутри цикла. в случае с массивами - это переменная индекса. 
                for (int i = 0; i < size; i++) // Первый блок может и отсутствовать, НО! его точку с запятой в начале оставляем.
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

            bool FindNum (int[] array, int a)
            {
                
                for (int i = 0 ; i < array.Length ; i++)
                    if (array[i] == a) return true;
                    
                return false;
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[] myArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(myArray);
            Console.Write("Enter a looking number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FindNum(myArray, a));
            */

            //===task3. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
            
            
            int[] CreateRandomArray(int size, int minValue, int maxValue)
            {
                int[] array = new int[size]; 
                for (int i = 0; i < size; i++) 
                {
                    array[i] = new Random().Next(minValue, maxValue + 1);     
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

            int ElementQuantity (int[] array, int minEl, int maxEl)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > minEl && array[i] < maxEl) count++;
                }
                return count;
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());
            
            
            int[] myArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(myArray);

            Console.Write("Enter the Left border: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Right border: ");
            int b = Convert.ToInt32(Console.ReadLine());
            //int quantityEl = ElementQuantity(myArray, a, b)
            Console.WriteLine(ElementQuantity(myArray, a, b));   // Console.WriteLine(quantityEl);     

        }
}
}

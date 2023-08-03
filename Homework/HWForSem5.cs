using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeminarsCsharp.Homework
{
    public static class HWforSem5
    {
        public static void Launch()
        {
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2

            // Вариант 1. Когда вводим доп метод, который проверяет пределы массива на трехзначность и ругаеся, если они неверные. Взяла из образца по самоконтролю.
            /*
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

            int EventNum(int[] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0) count++;
                }
                return count;
            }

            bool ValidateMinMaxValue(int minValue, int maxValue)
            {
                if (minValue < 100 && maxValue > 1000)
                {
                    Console.WriteLine("Array should contain only tree digit numbers. Wrong min and/or max volumes");
                    return false;
                }
                return true;
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            if (ValidateMinMaxValue(minValue, maxValue))
            {
                int[] myArray = CreateRandomArray(length, minValue, maxValue);
                WriteArray(myArray);
                Console.WriteLine("Quantity of even numbers is " + EventNum(myArray));
            }
            */


            // Вариант 2. Тут интереснее) Если возможно - программа создает массив только из 3х значных чисел. Если нет - пишет ошибку.
            /*int[] CreateRandomArray(int size, int minValue, int maxValue)
            {
                int[] array = new int[size];

                int count = 0;
               
               for (int i = 0;  i < size; i++)
               {
                    array[i] = new Random().Next(minValue, maxValue + 1);
                    if (array[i] > 99 && array[i] < 1000)
                    {                        
                        count++;
                    }
               }
               if (count > 0) return array;
               else
               {
                    Console.WriteLine("Array should contain only tree digit numbers. Wrong min and/or max volumes");
                    int[] wrAr = new int[0];
                    return wrAr;
               }

            }

            void WriteArray(int[] array1)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.Write(array1[i] + " ");
                }
                Console.WriteLine();
            }

            int EventNum(int[] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0) count++;
                }
                return count;
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value(>99): ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value(<1001): ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[] myArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(myArray);

            Console.WriteLine("Quantity of even numbers is " + EventNum(myArray));
            */

            //Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
            //[3, 7, 23, 12] -> 19
            //[-4, -6, 89, 6]-> 0

            /*int[] CreateRandomArray(int size, int minValue, int maxValue)
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

            int SumOddPositions (int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i +=2) sum +=array[i];
                return sum;
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());


            int[] myArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(myArray);
            Console.WriteLine(SumOddPositions(myArray));
            */

            //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            //[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

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


            int FindMaxMinusMin(int[] array)
            {
                
                int FindMax(int[] array)
                {
                    int i = 1;
                    int maxN = array[0];
                    while (i < array.Length)
                    {
                        if (array[i] > maxN)
                        {
                            maxN = array[i];
                            i++;
                        }
                        else i++;                    
                    }
                    return maxN;
                }
                
                
                int FindMin(int[] array)
                {
                    int i = 1;
                    int minN = array[0];
                    while (i < array.Length)
                    {
                        if (array[i] < minN)
                        {
                            minN = array[i];
                            i++;
                        }
                        else i++;
                    }
                    return minN;

                }

                int maxMinMin = FindMax(array) - FindMin(array);
                return maxMinMin;
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[] myArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(myArray);

            Console.WriteLine(FindMaxMinusMin(myArray));
        }
    }
}

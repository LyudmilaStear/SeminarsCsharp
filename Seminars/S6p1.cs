using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S6p1
    {
        public static void Launch()
        {
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
            */
            /*
            void ShowNum(int num)
            {
                num += 10;
                Console.WriteLine(num);
            }

            int number = 5;

            ShowNum(number);

            Console.WriteLine(number);
            
            
            
            void ShowNum(int[] nums)
            {
                nums[0] += 10;
                Console.WriteLine(nums[0]);
            }

            int[] numbers = { 5, 7, 8 };

            ShowNum(numbers);

            Console.WriteLine(numbers[0]);
          */

            //Task1. Напишите программу, которая перевернёт одномерный массив
            //(последний элемент будет на первом месте, а первый - на последнем и т.д.)

            /*void ReverseArray(int[] array)
            {
                for (int i = 0; i < array.Length / 2; i++) 
                {
                    int tempr = array[i];
                    array[i] = array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = tempr;
                }
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[] myArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(myArray);
            ReverseArray(myArray);
            WriteArray(myArray);
            */

            // второй вар решения
            /*
            void ReverseArray2(int[] array2)
            {
                for (int i = 0, j = array2.Length - 1; i < j; i++, j--)
                {
                    int tempr = array2[i];
                    array2[i] = array2[j];
                    array2[j] = tempr;
                }
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[] myArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(myArray);
            ReverseArray2(myArray);
            WriteArray(myArray);
            */

            //Task2.
            //Напишите программу, которая принимает на вход три числа и проверяет,
            //может ли существовать треугольник с сторонами такой длины.
            //Каждая сторона должна быть меньше суммы двух других.
            /*
            bool CheckTriangle(int a, int b, int c)
            {
                return a < b + c && b < c + a && c < a + b;
            }

            Console.Write("Enter a length of 'a' side of triangle: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a length of 'b' side of triangle: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a length of 'c' side of triangle: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (CheckTriangle(a, b, c)) Console.WriteLine("It could be a triangle");
            else Console.WriteLine("It could not be a triangle");
            */

            //Task3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
            //Первые два числа Фибоначчи: 0 и 1. Т е нужно сгенерировать массив из N чисел Фибоначи.

            /*
            int[] Fibonachi(int size)
            {
                int[] fib_Array = new int[size];
                fib_Array[0] = 0;
                fib_Array[1] = 1;
                for(int i = 2; i < fib_Array.Length; i++) 
                {
                    fib_Array[i] = fib_Array[i - 1] + fib_Array[i - 2];
                }
                return fib_Array;
            }

            Console.Write("Enter a length of an array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Fibonachi(size); 
            WriteArray(Fibonachi(size));
            */


            //Task4. Напишите программу,
            //которая будет создавать копию заданного массива с помощью поэлементного копирования.
           
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
            
            int[] CopyMassiv(int[] array)
            {
                int[] newArr = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    newArr[i] = array[i];
                }
                return newArr;
            }

            Console.Write("Enter a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[] myArray = CreateRandomArray(length, minValue, maxValue);
            WriteArray(myArray);

            int[] newArray = CopyMassiv(myArray);
            WriteArray(newArray);

            //проверка
            myArray[0] = 0;
            WriteArray(myArray);
            WriteArray(newArray);

            */
        }
    }
}

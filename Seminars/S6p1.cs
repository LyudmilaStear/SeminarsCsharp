using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S6p1
    {
        public static void Launch()
        {

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

            void ReverseArray(int[] array)
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












        }
    }
}

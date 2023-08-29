using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S8p1
    {
        public static void Launch()
        {
            //Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. (делаем для любых строк)

            int[,] CreateRandom2dArr(int row, int col, int minVal, int maxVal)
            {
                int[,] arr2d = new int[row, col];
                for (int i = 0; i < arr2d.GetLength(0); i++)
                    for (int j = 0; j < arr2d.GetLength(1); j++)
                        arr2d[i, j] = new Random().Next(minVal, maxVal + 1);
                return arr2d;
            }

            void Show2dArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            void ChangeRows(int[,] array, int r1, int r2)
            {
                if (r1 >= 0 && r1 < array.GetLength(0) &&
                   r2 >= 0 && r2 < array.GetLength(0) &&
                   r1 != r2)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        int temp = array[r1, j];
                        array[r1, j] = array[r2, j];
                        array[r2, j] = temp;
                    }
                }
            }

            Console.Write("Enter a row quantity of an array: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coloumn quantity of an array: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[,] myArray = CreateRandom2dArr(row, col, minValue, maxValue);
            Show2dArray(myArray);

            Console.Write("Enter a first row to change: ");
            int row1n = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Enter a second row to change: ");
            int row2 = Convert.ToInt32(Console.ReadLine()) - 1;

            ChangeRows(myArray, row1n, row2);
            Show2dArray(myArray);





        }
    }
}

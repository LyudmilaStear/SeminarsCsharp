using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeminarsCsharp.Seminars
{
    public static class S7p1
    {
        public static void Launch()
        {
            //Task1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
            //Усли данные вводит только пользователь и мы уверены,что эти аргументы не нужны 
            /*
        int[,] CreateRandon2dArr() //int[,] CreateRandon2dArr( int row, int col, int minVal, int maxVal)
        {
            Console.Write("Enter a row quantity of an array: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coloumn quantity of an array: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minVal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxVal = Convert.ToInt32(Console.ReadLine()); 

            int[,] arr2d = new int[row, col];
            for (int i = 0;  i < arr2d.GetLength(0); i++)                
                for (int j = 0; j < arr2d.GetLength(1); j++)                    
                    arr2d[i, j] = new Random().Next(minVal, maxVal);                                        
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

        //Console.Write("Enter a row quantity of an array: ");
        //int row = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter a coloumn quantity of an array: ");
        //int col = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter the min possible value: ");
        //int minValue = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter the max possible value: ");
        //int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,]  myArray = CreateRandon2dArr();  //int[,]  myArray = CreateRandon2dArr(row, col, minValue, maxValue);
        Show2dArray(myArray);
            */

            int[,] CreateRandon2dArr( int row, int col, int minVal, int maxVal)
            {
                int[,] arr2d = new int[row, col];
                for (int i = 0; i < arr2d.GetLength(0); i++)
                    for (int j = 0; j < arr2d.GetLength(1); j++)
                        arr2d[i, j] = new Random().Next(minVal, maxVal);
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

            Console.Write("Enter a row quantity of an array: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coloumn quantity of an array: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[,]  myArray = CreateRandon2dArr(row, col, minValue, maxValue);
            Show2dArray(myArray);

        }
    }
}

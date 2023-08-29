using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SeminarsCsharp.Seminars
{
    public static class S8p2
    {
        public static void Launch()
        {
            //Task1. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
            /*
                1 2 3 
                4 5 6 
                7 8 9


                1 4 7
                2 5 8
                3 6 9
             */

            /*
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

            int[,] ChangeRowsToColoumns (int[,] array) //значение столбца встает в строку
            {
                
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = i + 1; j < array.GetLength(1); j++)
                    {
                        int temp = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = temp;                        
                    }                        
                }
                return array;
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

            ChangeRowsToColoumns(myArray);
            Show2dArray(myArray);
            */

            //Task2. Из двумерного массива целых чисел удалить строку и столбец,
            //на пересечении которых расположен наименьший элемент.
            /*
            4 5 6
            2 1 3
            7 8 9

            46
            79
            */

            
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

            int[,] DelteRowAndColoumnWithMinValue (int[,] array)
            {
                int minI = 0;
                int minJ = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                         
                        if (array[i, j] < array[minI, minJ])
                        {
                            minI = i;
                            minJ = j;                            
                        }                        
                    }                    
                }
                
                int[,] result =new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        if (i < minI && j < minJ) result[i,j] = array[i, j];
                        if (i < minI && j >= minJ) result[i, j] = array[i, j + 1];
                        if (i >= minI && j < minJ) result[i, j] = array[i + 1, j]; 
                        if (i >= minI && j >= minJ) result[i, j] = array[i + 1, j + 1];
                    }
                }
                return result;
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

           int[,] newArray = DelteRowAndColoumnWithMinValue(myArray);
            Show2dArray(newArray);
            
            

            



        }
    }
}

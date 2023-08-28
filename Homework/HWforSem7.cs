using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Homework
{
   public static class HWforSem7
    {
        public static void Launch()
        {
            //Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            //m = 3, n = 4.
            //0,5 7 - 2 - 0,2
            //1 - 3,3 8 - 9,9
            //8 7,8 - 7,1 9

            /*
            double[,] CreateRandom2dArr(int row, int col, double minVal, double maxVal)
            {
                double[,] arr2d = new double[row, col];

                Random random = new Random();

                for (int i = 0; i < arr2d.GetLength(0); i++)
                    for (int j = 0; j < arr2d.GetLength(1); j++)
                        arr2d[i, j] = Math.Round(minVal + (maxVal - minVal) * random.NextDouble(), 2);
                return arr2d;
            }

            void Show2dArray(double[,] array)
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
            double minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            double maxValue = Convert.ToInt32(Console.ReadLine());

            double[,] myArray = CreateRandom2dArr(row, col, minValue, maxValue);
            Show2dArray(myArray);
            */


            //Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            //и возвращает значение этого элемента или же указание, что элемента с такой позицией нет. void
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //1,7->элемента с такими индексами нет.

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


            void SearchElements (int[,] array, int i_search, int j_search)
            {
                if (i_search < 0 || i_search > array.GetLength(0) && j_search < 0 || j_search > array.GetLength(1)) Console.WriteLine($"There isn't elemet with such position {i_search}, {j_search}");
                else 
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            if (i == i_search && j == j_search)
                            {
                                Console.WriteLine("You are looking for " + array[i, j]);  
                            }                            
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

            Console.Write("Enter a row Position which you are looking for: ");
            int rowPosition = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coloumn Position which you are looking for: ");
            int colPosition = Convert.ToInt32(Console.ReadLine());

            SearchElements(myArray, rowPosition, colPosition);
            */



            //Задача 52.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце. double[]
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

            // У меня загвоздка с этим кодом. Не могу сделать, чтоб double метод работал.  Только через void  получается.
            //Что я упускаю? Наверно, какое то базовое правило. 
            //Как бы я в принципе улавливаю, что return должно быть после всех циклов, чтобы заработало. Но тогда не всех столбцов значения вернутся. 


            /*
             double AveregeColomns(int[,] array)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        sum += array[i, j];
                    }
                    double average = sum / (array.GetLength(1));
                    return average;
                }

            }
            */

            int[,] CreateRandom2dArr(int row, int col, int minVal, int maxVal)
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


            void AveregeColomns(int[,] array)
            {     
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    double sum = 0;
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        sum += array[i, j];                        
                    }                     
                    double average = sum / (array.GetLength(0));
                    Console.WriteLine($"{average} is averege of {j} colomn");
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

            AveregeColomns(myArray); 
           
            






        }
   }
}

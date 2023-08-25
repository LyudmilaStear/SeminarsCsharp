using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S7p2
    {
        public static void Launch()
        {
            //Task1. Задайте двумерный массив размера m на n,
            //каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

            /*
            int[,] CreateRandon2dArr(int row, int col)
            {
                int[,] arr2d = new int[row, col];
                for (int i = 0; i < arr2d.GetLength(0); i++)
                    for (int j = 0; j < arr2d.GetLength(1); j++)
                        arr2d[i, j] = i + j;
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

            int[,] myArray = CreateRandon2dArr(row, col);
            Show2dArray(myArray);
            */

            //Task2. Задайте двумерный массив. Найдите элементы,
            //у которых оба индекса чётные, и замените эти элементы на их квадраты.

            /*
            int[,] CreateRandon2dArr(int row, int col, int minVal, int maxVal)
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

            void NewArrEvenToSquare(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i += 2)
                {
                    for (int j = 0; j < array.GetLength(1); j+= 2)
                    {
                         array[i, j] = array[i, j] * array[i, j];   //Math.Pow(array[i, j], 2); not work                        
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

            int[,] myArray = CreateRandon2dArr(row, col, minValue, maxValue);
            Show2dArray(myArray);
            NewArrEvenToSquare(myArray); 
            Console.WriteLine();
            Show2dArray(myArray);
            */

            //Task3. Задайте двумерный массив. Найдите сумму элементов,
            //находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

            /*
            int[,] CreateRandon2dArr(int row, int col, int minVal, int maxVal)
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

            int SumMainElements(int[,] array)
            {
                int sum = 0;
                for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
                {
                    //Console.WriteLine($"{sum} + {array[i, i]}"); 
                    if (i == array.GetLength(0) - 1 && i < array.GetLength(1) - 1) Console.Write($"{array[i, i]} = ");
                    else Console.Write($"{array[i, i]} + ");
                    sum += array[i, i];                    
                }
                Console.WriteLine();
                return sum;
            }

            //int SumMainElements (int[,] array)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < array.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array.GetLength(1); j++)
            //        {
            //            if ( i == j) sum += array[i, j];
            //        }
            //    }
            //    return sum;
            //}

            Console.Write("Enter a row quantity of an array: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coloumn quantity of an array: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[,] myArray = CreateRandon2dArr(row, col, minValue, maxValue);
            Show2dArray(myArray);

            int sum = SumMainElements(myArray);
            Console.Write(sum);
            */

            //Task4. Отсортировать содержимое строк по убыванию. у двумерного массива.

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


            void SortingRows(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - 1; k++)
                        {
                            if (array[i, k + 1] > array[i, k])
                            {
                                int max = array[i, k];
                                array[i, k] = array[i, k + 1];
                                array[i, k + 1] = max;
                            }
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

            SortingRows(myArray); 
            Console.WriteLine();

            Show2dArray(myArray);

        }
    }
}

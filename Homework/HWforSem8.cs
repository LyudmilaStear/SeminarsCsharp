using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeminarsCsharp.Homework
{
    public static class HWforSem8
    {
        public static void Launch()
        {

            //mathprofiпочитать про матрицы

            //Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            //Например, задан массив:
            //Сделано в предыдущем дз.




            //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //5 2 6 7
            //Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

            int SumOfElementsInRow(int[,] array, int i)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum = sum + array[i, j];
                }
                return sum;
            }

            void RowOfMinSum (int[,] array)
            {
                
                int rowWithMinSum = 1;
                int minSum = SumOfElementsInRow(array, 0);
                for ( int i = 1; i < array.GetLength(0); i++)
                {
                    //minSum += SumOfElementsInRow(array, i);
                    if (SumOfElementsInRow(array, i) < minSum)
                    {
                        minSum = SumOfElementsInRow(array, i);
                        rowWithMinSum = i + 1;
                    }
                    
                }
                Console.WriteLine($"{minSum} is the minimal sum of elements in row. Row number is {rowWithMinSum}");
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

            RowOfMinSum(myArray);
            */

            //Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
            //Например, даны 2 матрицы:
            //            2 4 | 3 4
            //3 2 | 3 3
            //Результирующая матрица будет:
            //            18 20
            //15 18




            //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу,
            //которая будет построчно выводить массив, добавляя индексы каждого элемента.
            //Массив размером 2 x 2 x 2
            //66(0, 0, 0) 25(0, 1, 0)
            //34(1, 0, 0) 41(1, 1, 0)
            //27(0, 0, 1) 90(0, 1, 1)
            //26(1, 0, 1) 55(1, 1, 1)

            /*
            int[,,] CreateWriteRandom3dArray(int layers, int row, int col)
            {
                int[,,] random3dArray = new int[layers, row, col];
                for (int i = 0; i < random3dArray.GetLength(0); i++)
                {
                    for (int j = 0; j < random3dArray.GetLength(1); j++)
                    {
                        int z = 0;
                        while (z < random3dArray.GetLength(2))
                        {

                            int notRrapeatedNum = new Random().Next(10, 100);
                            if (NoReapeatedNum(random3dArray, notRrapeatedNum)) continue;
                            random3dArray[i, j, z] = notRrapeatedNum;
                            Console.Write($"{random3dArray[i, j, z]}({i}, {j}, {z}), ");
                            z++;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                return random3dArray;
            }

            bool NoReapeatedNum(int[,,] random3dArray, int randNumber)
            {
                for (int z = 0; z < random3dArray.GetLength(2); z++)
                {
                    for (int i = 0; i < random3dArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < random3dArray.GetLength(1); j++)
                        {
                            if (random3dArray[i, j, z] == randNumber)
                            {
                                return true;
                            }                            
                        }
                    }
                }
                return false;
            }

            Console.Write("Enter a row quantity of an array: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coloumn quantity of an array: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a layers quantity of an array: ");
            int layers = Convert.ToInt32(Console.ReadLine());
            

            int[,,] myArray = CreateWriteRandom3dArray(layers, row, col);
            */

            //Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
            //Например, на выходе получается вот такой массив:
            //01 02 03 04
            //12 13 14 05
            //11 16 15 06
            //10 09 08 07

            int[,] CreateRandom2dArr(int row, int col)
            {
                int[,] arr2d = new int[row, col];
                
                int i = 0;
                int j = 0;
                arr2d[0, 0] = 0;
                int tempForRow = 0;
                int tempForCol = 0;
                //int temp = 1;
                //while цикдл   предположим
                
                for (i = tempForRow, j = 0; j < col; j++)
                {
                     arr2d[i, j] = arr2d[i, j]++;

                }
                row = row - 1;
                tempForRow++;

                for (j = col - 1;  i < row; i ++)
                {
                     arr2d[i, j] = arr2d[i, j] + 1;
                }
                col--;

                for (i = row, j = col - 1; j >= 0; j --)
                {
                    arr2d[i, j] = arr2d[i, j] + 1;
                }
                row--;
                
                for(j = tempForCol, i = row; i >= 0; i--)
                {
                    arr2d[i, j] = arr2d[i, j] + 1;
                }
                col--;
                tempForCol++;
                //temp ++;  это еще не придумала какой счетчик нужен для зацикливания хождения по кругу
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
            //Console.Write("Enter the min possible value: ");
            //int minValue = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the max possible value: ");
            //int maxValue = Convert.ToInt32(Console.ReadLine());

            int[,] myArray = CreateRandom2dArr(row, col);
            Show2dArray(myArray);
            /*
             Queue<int> queue = new Queue<int>(Enumerable.Range(1, 10).OrderBy(_=>rnd.Next()));

            while(queue.Count > 0)
            */




        }
}
}

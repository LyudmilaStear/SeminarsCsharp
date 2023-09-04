using System;
using System.Collections.Generic;
using System.Data;
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


            /*
            int[,] CreateRandom2dArr(int row, int col, int minVal, int maxVal)
            {
                int[,] arr2d = new int[row, col];
                for (int i = 0; i < arr2d.GetLength(0); i++)
                    for (int y = 0; y < arr2d.GetLength(1); y++)
                        arr2d[i, y] = new Random().Next(minVal, maxVal);
                return arr2d;
            }

            void Show2dArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int y = 0; y < array.GetLength(1); y++)
                    {
                        Console.Write(array[i, y] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            void SortingRows(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int y = 0; y < array.GetLength(1); y++)
                    {
                        for (int z = 0; z < array.GetLength(1) - 1; z++)
                        {
                            if (array[i, z] < array[i, z + 1])
                            {
                                int min = array[i, z + 1];
                                array[i, z + 1] = array[i, z];
                                array[i, z] = min;
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

            */


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
                    for (int y = 0; y < arr2d.GetLength(1); y++)
                        arr2d[i, y] = new Random().Next(minVal, maxVal + 1);
                return arr2d;
            }

            void Show2dArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int y = 0; y < array.GetLength(1); y++)
                    {
                        Console.Write(array[i, y] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int SumOfElementsInRow(int[,] array, int i)
            {
                int sum = 0;
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    sum = sum + array[i, y];
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
            int row = Convert.ToInt32(Console.ReadLine());  //int row = Parse
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

            //second var
            /*
            int[,] CreateRandom2dArr(int row, int col, int minVal, int maxVal)
            {
                int[,] arr2d = new int[row, col];
                for (int i = 0; i < arr2d.GetLength(0); i++)
                    for (int y = 0; y < arr2d.GetLength(1); y++)
                        arr2d[i, y] = new Random().Next(minVal, maxVal + 1);
                return arr2d;
            }

            void Show2dArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int y = 0; y < array.GetLength(1); y++)
                    {
                        Console.Write(array[i, y] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int RowWithMinSumOfElements(int[,] array)
            {
                int row = 0;
                int minsum = 0;
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    minsum = minsum + array[0, y];
                }
                Console.WriteLine($"MinSum is {minsum}");

                for (int i = 1; i < array.GetLength(0); i++)
                {
                    int sum = 0;
                    for (int y = 1; y < array.GetLength(1); y++) 
                    { 
                        sum += array[i, y];
                    }
                    if (sum < minsum)
                    {
                        minsum = sum;
                        row = i;
                    }
                }
                return row + 1;
            }
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
                int[,,] tempFor3D = new int[layers, row, col];
                for (int i = 0; i < tempFor3D.GetLength(0); i++)
                {
                    for (int y = 0; y < tempFor3D.GetLength(1); y++)
                    {
                        int z = 0;
                        while (z < tempFor3D.GetLength(2))
                        {

                            int notRrapeatedNum = new Random().Next(10, 100);
                            if (NoReapeatedNum(tempFor3D, notRrapeatedNum)) continue;
                            tempFor3D[i, y, z] = notRrapeatedNum;
                            Console.Write($"{tempFor3D[i, y, z]}({i}, {y}, {z}), ");
                            z++;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                return tempFor3D;
            }

            void PrintArray (int array3D[,,])
            {
                for (int i = 0; i < array3D.GetLength(0); i++)
                {
                    for (int y = 0; y < array3D.GetLength(1); y++)
                    {
                        for (int z = 0; z < array3D.GetLength(2); z++)
                            {
                                Console.Write($"{array3D[i, y, z]}({i}, {y}, {z}), ");
                            }
                            Console.WriteLine();
                    }
                }
            }
            
            bool NoReapeatedNum(int[,,] tempFor3D, int randNumber)
            {
                for (int z = 0; z < tempFor3D.GetLength(2); z++)
                {
                    for (int i = 0; i < tempFor3D.GetLength(0); i++)
                    {
                        for (int y = 0; y < tempFor3D.GetLength(1); y++)
                        {
                            if (tempFor3D[i, y, z] == randNumber)
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

            //памятка

            //int[,,] CreateWriteRandom3dArray(int layers, int row, int col)
            //{
            //    int[,,] tempFor3D = new int[layers, row, col];
            //    for (int i = 0; i < tempFor3D.GetLength(0); i++)
            //    {
            //        for (int y = 0; y < tempFor3D.GetLength(1); y++)
            //        {
            //            for(int z = 0; z < tempFor3D.GetLength(2); z++)
            //            {
            //                tempFor3D[i, y, z] = new Random().Next(10, 100);
            //            }                        
            //        }                    
            //    }
            //    return tempFor3D;
            //}

            //Second sol

            /*
            void CreateWriteRandom3dArray(int[,,] array3D)
            {
                int[] tempFor3D = new int[array3D.Length];
                if (array3D.Length > 90) Console.Write("Wrong amount of rows, layers and coloumns. row*col*layres should be less than 90!");
                {
                    for (int i = 0; i < tempFor3D.Length; i++)
                    {
                        tempFor3D[i] = new Random().Next(10, 100);
                        if (i >= 1)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                while (tempFor3D[i] == tempFor3D[j])
                                {
                                    tempFor3D[i] = new Random().Next(10, 100);
                                    j = 0;
                                }
                            }
                        }

                    }
                    int count = 0;
                    for (int x = 0; x < array3D.GetLength(0); x++)
                    {
                        for (int y = 0; y < array3D.GetLength(1); y++)
                        {
                            for (int z = 0; z < array3D.GetLength(2); z++)
                            {
                                array3D[x, y, z] = tempFor3D[count];
                                count++;
                            }
                        }
                    }
                }

            }

            void PrintArray(int[,,] array3D)
            {
                for (int i = 0; i < array3D.GetLength(0); i++)
                {
                    for (int j = 0; j < array3D.GetLength(1); j++)
                    {
                        for (int k = 0; k < array3D.GetLength(2); k++)
                        {
                            Console.Write($"{array3D[i, j, k]}({i}, {j}, {k}), ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.Write("Enter a row quantity of an array: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coloumn quantity of an array: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a layers quantity of an array: ");
            int layers = Convert.ToInt32(Console.ReadLine());

            int[,,] arr3d = new int[layers, row, col];
            
            CreateWriteRandom3dArray(arr3d);
            PrintArray(arr3d);
            */

            //Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
            //Например, на выходе получается вот такой массив:
            //01 02 03 04
            //12 13 14 05
            //11 16 15 06
            //10 09 08 07


            // Попытка 1. (есть еще) я пыталась - не смогла закончить.
            /*        
                        
            int[,] CreateRandom2dArr(int row, int col)
            {
                int[,] arr2d = new int[row, col];

                int i;
                int j;

                int value = 1;
                int tempForRow = 0;
                int tempForCol = 0;
                //int temp = 1;
                //while цикдл   предположим
                
                for (i = tempForRow, j = tempForCol; j < col; j++)
                {
                    arr2d[i, j] = value++;
                    
                }
                row = row - 1;
                tempForRow++;

                for (j = col - 1;  i < row; i ++)
                {
                    arr2d[i, j] = value++;
                }
                col--;

                for (i = row, j = col - 1; j >= 0; j --)
                {
                    arr2d[i, j] = value++;
                }
                row--;
                
                for(j = tempForCol, i = row; i >= 0; i--)
                {
                    arr2d[i, j] = value++;
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
            */

            // Попытка 2. (помогали)
            /*
           Console.Write("Enter a row quantity of an array: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coloumn quantity of an array: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, col];
            int value = 1;

            void Show2dArray(int row, int col)
            {
                Console.Clear();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j].ToString("000") + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"row1:{row:00} col:{col:00}");
                Thread.Sleep(100);
            }

            int StepRight(int row, int col)
            {
                int j = col;
                for (; j < arr.GetLength(1) && arr[row, j] == 0; j++)
                {
                    arr[row, j] = value++;
                    Show2dArray(row, j);
                }
                return j - 1;
            }
            int StepDown(int row, int col)
            {
                int i = row;
                for (; i < arr.GetLength(0) && arr[i, col] == 0; i++)
                {
                    arr[i, col] = value++;
                    Show2dArray(i, col);
                }
                return i - 1;
            }
            int StepLeft(int row, int col)
            {
                int j = col;
                for (; j >= 0 && arr[row, j] == 0; j--)
                {
                    arr[row, j] = value++;
                    Show2dArray(row, j);
                }
                return j + 1;
            }

            int StepUp(int row, int col)
            {
                int i = row;
                for (; i >= 0 && arr[i, col] == 0; i--)
                {
                    arr[i, col] = value++;
                    Show2dArray(i, col);
                }
                return i + 1;
            }

            int col1 = 0;
            int row1 = 0;
            arr[0, 0] = value++;

            while (true)
            {
                if (arr[row1, col1 + 1] != 0) break;
                col1 = StepRight(row1, col1 + 1);

                if (arr[row1 + 1, col1] != 0) break;
                row1 = StepDown(row1 + 1, col1);

                if (arr[row1, col1 - 1] != 0) break;
                col1 = StepLeft(row1, col1 - 1);

                if (arr[row1 - 1, col1] != 0) break;
                row1 = StepUp(row1 - 1, col1);
            }
           */


            // Решение с семинара
            /*
            void SpiralFillArr(int[,] arr, int size)
            {
                int value = 1;       //значение элемента [0,0]
                int i = 0;
                int j = 0;
                
                while (value <= size * size )  //диапазон значений
                {
                    arr[i, j] = value;
                     if (i <= j + 1 && i + j < size - 1)  // Заполнение  строки слева направо
                        j++;                             //Возврат увеличенного значения j
                    else if (i < j && i + j >= size - 1) //Заполнение столбцов вниз
                        i++;                             //Возврат увеличенного значения i
                    else if (i >= j && i + j > size - 1) //Заполнение  строки справа налево
                        j--;                             //Возврат уменьшенного значения j
                    else                                 //Заполнение столбцов вверх
                        i--;                            //Возврат увеличенного значения i
                    value++;                             //
                }
            }

            void Show2dArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int y = 0; y < array.GetLength(1); y++)
                    {
                        if (array[i, y] < 10)
                            Console.Write($"00{array[i, y]} ");
                        else if (array[i, y] >= 10 && array[i, y] < 100)
                            Console.Write($"0{array[i, y]} ");
                        else Console.Write($"{array[i, y]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.Write("Enter a row  quantity of an array, which is also column quantity: ");
            int row = Convert.ToInt32(Console.ReadLine());
            
            int[,] arr = new int[row, row];
            //int userArrSize = arr.Length;

            SpiralFillArr(arr, row);
            Show2dArray(arr);
            */

         
            //еще вариант одноклассника
            /*
            int[,] CreateSpiral2dArray()
            {
                Console.Write("Input a rows of array: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input a columns of array: ");
                int columns = Convert.ToInt32(Console.ReadLine());

                int dx = 0;
                int dy = 1;
                int x = 0;
                int y = 0;
                int temp = 0;
                int nx = 0;
                int ny = 0;
                int[,] array = new int[rows, columns];

                for (int i = 1; i < rows * columns + 1; i++)
                {
                    array[x, y] = i;
                    if (x + dx < 0) nx = rows - Math.Abs(x + dx);
                    else nx = x + dx;
                    if (y + dy < 0) ny = columns - Math.Abs(y + dy);
                    else ny = y + dy;
                    if (array[nx % rows, ny % columns] != 0)
                    {
                        temp = -dx;
                        dx = dy;
                        dy = temp;

                    }
                    x = x + dx;
                    y = y + dy;
                }
                return array;
            }
            */

        }
    }
}

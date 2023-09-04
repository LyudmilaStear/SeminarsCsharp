using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Homework
{
    public static class HWForSem8Task62
    {
        public static void Launch()
        {
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

        }
    }
}

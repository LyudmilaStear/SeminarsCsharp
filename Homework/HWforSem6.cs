using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Homework
{
    public static class HWforSem6
    {
        public static void Launch()
        {

            //Task1.Пользователь вводит с клавиатуры M чисел.
            //Посчитайте, сколько чисел больше 0 ввёл пользователь. с/без массива, но с методом.
            //0, 7, 8, -2, -2-> 2
            //1, -7, 567, 89, 223-> 3

            /*
             void WriteArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }

            int Mes (string message)
            {
                 Console.WriteLine (message);
                string value = Console.ReadLine ();
                int result = Convert.ToInt32(value);
                return result;
            }

            int[] UserArray(int length)
            {
                int[] arr = new int[length];
                for (int i = 0;  i < length; i++)
                {
                    arr[i] = Mes($"Введите {i + 1}-й элемент");
                }
                return arr;
            }

            int CountPosNum(int[] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length;i++)
                {
                    if (array[i] > 0) count++;                                              
                }
                return count;
            }

            int length = Mes("Введите количество элементов >");
            int[] userArr;
            userArr = UserArray(length);
            WriteArray(userArr);
            Console.WriteLine($"количество чисел больше нуля - {CountPosNum(userArr)}");
            */

            /*
            int Mes(string message)
            {
                Console.WriteLine(message);
                string value = Console.ReadLine();
                int result = Convert.ToInt32(value);
                return result;
            }

            int UserNumbrs(int numAmount)
            {
                int count = 0;
                for (int i = 1; i <= numAmount; i++)
                {
                    Console.WriteLine($"Введите {0 + i}-ое число для проверки");
                    int numb = Convert.ToInt32(Console.ReadLine());
                    if (numb > 0) count++;
                }
                return count;
            }

            Console.WriteLine("Введите, кол-во чисел, которое планируется проверять");
            int numToCheck = Convert.ToInt32(Console.ReadLine());
            int posNumbrs = UserNumbrs(numToCheck);
            Console.WriteLine($"Веедено {posNumbrs} положительных чисел");
            */


            //Task2.Напишите программу, которая найдёт точку пересечения двух прямых,
            //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
            //значения b1, k1, b2 и k2 задаются пользователем.
            //b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
            //паралельны, пересекаются, совпадают.

            // Данная задача решается как система двух уравнений.
            // Применив вычитание из первого уравнения второго, а
            // также несложные преобразования, получим для координаты «x»
            // x = (b2 - b1) / (k1 - k2). Затем, подставив в
            // уравнение полученное значение «x», найдём координату
            // «y» точки пересечения двух прямых.

            /*
            float WriteWait(string outLine)
            {
                Console.Write(outLine);
                float inNumber = Convert.ToSingle(Console.ReadLine());
                return inNumber;
            }

            void СalculationIntersection(float k1, float k2, float b1, float b2)
            {
                if (k1 - k2 == 0 && b2 - b1 == 0)
                    Console.WriteLine("Прямые совпадают.");
                else if (k1 - k2 == 0 && b2 - b1 != 0)
                    Console.WriteLine("Прямые параллельны");
                else
                {
                    float x = (b2 - b1) / (k1 - k2);
                    float y = x * k1 + b1;
                    Console.WriteLine($"Прямые пересекаются в точке с координатами ({x}; {y}).");
                }
            }

            Console.WriteLine("Программа вычисляет координаты точки пересечения двух прямых, " +
                                "заданных уравнением y = k * x + b.\n");

            float inK1 = WriteWait("Введите коэффициент k первой прямой: ");
            float inB1 = WriteWait("Введите смещение b первой прямой: ");
            float inK2 = WriteWait("Введите коэффициент k второй прямой: ");
            float inB2 = WriteWait("Введите смещение b второй прямой: ");

            СalculationIntersection(inK1, inK2, inB1, inB2);
            */

            //Task3.Extra. Написать программу, преобразующую число
            //из десятеричной системы счисления в двоичную.
            /*
            int num1 = 123 / 2; //61
            double num2 = 123 % 2; //1
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            int num1_2 = 123 / 10; //12
            double num2_2 = 123 % 10; //3
            Console.WriteLine(num1_2);
            Console.WriteLine(num2_2);
            */

            string Transform10Into2(int num)
            {
                string numIn2 = String.Empty;
                while (num > 0)
                {
                    int dig = num % 2;
                    num = num / 2;
                    //numIn2 = Convert.ToString(dig) + numIn2; // и на этом все
                    numIn2 = numIn2 + Convert.ToString(dig);
                }
                
                Console.WriteLine(numIn2);
                
                string revNumIn2 = String.Empty;

                int oldNum = Convert.ToInt32(numIn2);
                int i = 0;
             
                while (i < numIn2.Length)
                {
                    int rightDigit = oldNum % 10;
                    oldNum = oldNum / 10;
                    i++;

                    revNumIn2 = revNumIn2 + Convert.ToString(rightDigit);
                }

                return revNumIn2;
            }

            Console.WriteLine("Введите число для перевода в двоичную систему ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Transform10Into2(userNum));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public  static class S3p1Task1
    {
        public static void Launch()
        {
            /* void методы ничего не возвращают. Обычно не ппишем в них команду return
             к void относят Console.WriteLine and Console.Write
            Console.WriteLine(
                Math.Pow(5-основание степени, 2- сама степень)
                Math.Sqrt(25-аргумент, из которого находдится квадратный корень); и выддает ответ double.
                Math.Round(Math.Sqrt(24) то что округляем, 2 - степень точчности(колво знаков после запятой));

            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Round(Math.Sqrt(24), 2)); - это лучше использовать в самом конце, ПЕРЕД ВЫВОДОМ РЕЗУЛЬТАТА.
             */


            //Task1. Напишите программу, которая по заданному номеру четверти,
            //показывает диапазон возможных координат точек в этой четверти (x и y)

            /*void WriteRange(int quadrant)
            {
                if (quadrant <= 0 || quadrant > 4) Console.WriteLine("Incorrect date");
                else if (quadrant == 1) Console.WriteLine("x > 0 and y > 0");
                else if (quadrant == 2) Console.WriteLine("x < 0 and y > 0");
                else if (quadrant == 3) Console.WriteLine("x < 0 and y < 0");
                else if (quadrant == 1) Console.WriteLine("x > 0 and y < 0"); // оптимальнее else Console.WriteLine("x > 0 and y < 0); т к остальные возможные варианты уже перебрали и этот всегдда может быть только 4 областью плоскости координат
            }

            Console.WriteLine("Please enter a number of quadrant: ");
            int quard = Convert.ToInt32(Console.ReadLine());

            WriteRange(quard);
            */

            //Task 2. Напишите программу, которая принимает на вход координаты точки (X и Y),
            //причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. Вводим и выводим данные int.

            /* доработать!!!!
             * void QuadrantNumber(int x, int y)
            {
                if (x > 0 && y > 0) Console.WriteLine("The 1st qhuadrant");
                else if (x < 0 && y > 0) Console.WriteLine("The 2nd qhuadrant");
                else if (x < 0 && y < 0) Console.WriteLine("The 3rd qhuadrant");
                else if (x > 0 && y < 0) Console.WriteLine("The 4th qhuadrant");
                return 0;
            }
            Console.WriteLine("Please enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int quad = QuadrantNumber(x, y);
            Console.WriteLine(quad);
            */


            /*
             int QuadrantNumber(int x, int y)
            {
                if (x == 0 && y == 0) Console.WriteLine("Wrong data.");
                else if (x > 0 && y > 0) return 1;
                else if (x < 0 && y > 0) return 2;
                else if (x < 0 && y < 0) return 3;
                return 4;
            }
            Console.WriteLine("Please enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int quad = QuadrantNumber(x, y);
            Console.WriteLine(quad);
            */


            //Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N. Метод типа void, аргумет один. 
            //1 - 1
            //2 - 4
            //3 - 9
            //4 - 16

            /*void Squaer(int n)
            {
                if (n <= 0) Console.WriteLine("THE INCORRECT NUMBER");
                else
                {
                    int count = 1;
                    while (count <= n)
                    {
                        Console.WriteLine($"{count} - {Math.Pow(count, 2)}");
                        count++;
                    }
                }
                
            }

            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Squaer(num);
            */

            // Task 4. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
            // результат буддет double. Вводные данные тоже можно будет сдделать double. 

            ///что не так работает
            ///
             double DistanceLine(double x1, double y1, double x2, double y2)
            {
                return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            }

            Console.WriteLine("Input x1: ");

            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double distance = DistanceLine(x1, y1, x2, y2);
            Console.WriteLine(distance);
            
            /* работает корректно
            double DistanceLine(double x1, double y1, double x2, double y2)
            {
                double deltax = x2 - x1;
                double deltay = y2 - y1;
                return Math.Sqrt(Math.Pow(deltax, 2) + Math.Pow(deltay, 2));
            }

            Console.WriteLine("Input x1: ");

            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double distance = DistanceLine(x1, y1, x2, y2);
            Console.WriteLine(distance);
            */

            //палиндром - это строка, которая с обеих сторон ччитается одинаково
        }
    }
}

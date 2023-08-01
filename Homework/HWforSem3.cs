using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Homework
{
    public static class HWforSem3
    {
        public static void Launch()
        {
            //Задача 19
            //Напишите программу, которая принимает на вход пятизначное число и проверяет,
            //является ли оно палиндромом.
            //14212->нет
            //12821->да
            //23432->да

           /* variant 1
            * bool Polindrom (int num)
            {
                 int revNum = 0;
                int origNum = num;
                 while(num > 0)
                 {
                     revNum = revNum + num % 10;
                     revNum = revNum * 10;
                     num = num / 10;
                 }
                 revNum = revNum / 10;

                 if (revNum == origNum) return true;
                 else return false;
             }

             Console.WriteLine("Введите число для проверки на полиндромность: ");
             int numb = Convert.ToInt32(Console.ReadLine());
             bool x = Polindrom (numb);

             if (x == true) Console.WriteLine($"{numb} is Pulindrom");
             else Console.WriteLine($"{numb} is not Pulindrom");
           */

            

            /* Variant2. По сути то же, что и 1.
             * void Polindrom(int num)
            {
                int revNum = 0;
                int orNum = num;
                while (num > 0)
                {
                    revNum = revNum + num % 10;
                    revNum = revNum * 10;
                    num = num / 10;
                }
                revNum = revNum / 10;

                if (revNum == orNum) Console.WriteLine($"{orNum} is Pulindrom");
                else Console.WriteLine($"{orNum} is not Pulindrom");
            }
            Console.WriteLine("Введите число для проверки на полиндромность: ");
            int numb = Convert.ToInt32(Console.ReadLine());

            Polindrom(numb);
            */

            /* решение с "хаками" от друга вар1(для себя, чтобы знать, что и так бывает):
            Console.WriteLine("Введите число для проверки на полиндромность: ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string(x.ToString().Reverse().ToArray()) == x.ToString());

            решение с "хаками" от друга вар2:
            Console.WriteLine("Введите число для проверки на полиндромность: ");
            var x = Convert.ToInt32(Console.ReadLine());
            var isPolyndrom = new string(x.ToString().Reverse().ToArray()) == x.ToString();
            Console.WriteLine(isPolyndrom ? $"{x} is Polyndrom" : $"{x} is not Polyndrom" );
            */

            
            /* альтернативное решение с массивами. Сама 100%.
             * void NumPulindrom(string num)
            {
                //string numb = Convert.ToString(num);
                int numLength = num.Length;
                int index = 0;
             
                int leftDigit = num[index];
                int rightDigit = num[numLength - 1];
                if (leftDigit == rightDigit && num.Length > 1)
                {
                    while (index < numLength / 2)
                    {
                        index++;
                        numLength--;
                    }
                    Console.WriteLine($"{num} is a Pulindrom");
                }
                else Console.WriteLine($"{num} is not a Pulindrom");
            }
                Console.WriteLine("Enter a number: ");
                string x = Console.ReadLine();
                NumPulindrom(x);
            */
            


            /* альт решение только для 5и значных, без метода.
            Console.WriteLine("Введите число: ");
            string number = Console.ReadLine();
            int len = number.Length;

            if (len == 5)
            {
                if (number[0] == number[4] && number[1] == number[3])
                {
                    Console.WriteLine($"{number} - Палиндром");
                }
                else
                {
                    Console.WriteLine($"{number} - НЕ палиндром");
                }
            }
            else
            {
                Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
            }
            */



            //Задача 21
            //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            //A(3, 6, 8); B(2, 1, -7), -> 15.84
            //A(7, -5, 0); B(1, -1, 9)-> 11.53

            /* double LengthLine (double xa, double ya, double za, double xb, double yb, double zb)
            {
                return Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
            }

            Console.WriteLine("Input xa: ");
            double xa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input ya: ");
            double ya = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input za: ");
            double za = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input xb: ");
            double xb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input yb: ");
            double yb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input zb: ");
            double zb = Convert.ToDouble(Console.ReadLine());

            double distance = LengthLine(xa, ya, za, xb, yb, zb);
            Console.WriteLine(distance);
            */

            //Задача 23
            //Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
            //3-> 1, 8, 27
            //5-> 1, 8, 27, 64, 125

            /* void NumCube(int num)
            {
                int tempale = 1;
                if (num < 0)
                {
                    while (tempale >= num)  //while (tempale <= Math.Sqrt(Math.Pow(num, 2)))
                    {
                        Console.WriteLine($"{tempale} - {Math.Pow(tempale, 3)}");
                        tempale--;
                    }
                }
                if (num > 0)
                {
                    while (tempale <= num)  //while (tempale <= Math.Sqrt(Math.Pow(num, 2)))
                    {
                        Console.WriteLine($"{tempale} - {Math.Pow(tempale, 3)}");
                        tempale++;
                    }
                }
                if (num == 0) Console.WriteLine("0 = 0");
            }

            Console.WriteLine("Insert any number: ");
            int numb = Convert.ToInt32(Console.ReadLine());

            NumCube(numb);
            */
        }
    }
}

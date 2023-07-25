using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    /// <summary>
    /// имя переменной всегда пишется с маленькой буквы
    /// закоментировать несколько строк cntrl+/
    /// Console.ReadLine() работает только со строками!! Для ввода чисел ( int num = ReadLine();) - нужно конвектирование. int num = Convert.ToInt32(Console.readLine());
    /// Форматированный вывод, пример: Console.WriteLine($"My numbers are {num1} and {num2} and it is good!"); используем когда переменные по центру, вначале, их там несколько
    /// </summary>
    public static class p1Theory
    {
        public static void Launch()
        {
            //SeminarC# 1
            //Theory
            /* Console.WriteLine("Какой--то текст, просто посмотреть команду WriteLine");
           переменные -- ячейки с информацией для хранения данных. Именнованные "коробочки для хранения информации. Цифры, логические, текст и тд.
            КАКИЕ БЫВАЮТ ПЕРЕМЕННЫЕ. 
            INT - целое число. любое. Можно написать сразу со значением. а можно оставить просто "место" под нее `int varA;`
            double - дробное число
            string
            bool
           
            int intNumber = 25;
            double doubleNumber = 12.12;
            string stringText = "some text";
            bool logicVar = false;
            bool logicVar2 = true;
            */

            int num1 = 9;
            int num2 = 10;
            Console.WriteLine("My numbers are " + num1 + " and " + num2 + " and it is good!");
            Console.WriteLine($"My numbers are {num1} and {num2} and it is good!");
            
            
            /*
            Где то здесь ошибка:
            int num3 = New Random().Next(0, 101);
            Console.WriteLine("My secondNumber is " + num3);

            Console.Write("Input a number: ");
            int num = Console.ReadLine(); - неправильная строка, т к Read.Line() работает только с текстом
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your numberr is " + num);

            Не ставим ; при if while else
            */
        }
    }
}

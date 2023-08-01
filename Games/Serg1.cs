using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Games
{
    public static class Serg1
    {
        public static void Launch() 
        {
            //void Polindrom(int num)
            //{
            //    int revNum = 0;
            //    int origNum = num;
            //    while (num > 0)
            //    {
                    
            //        revNum = revNum + num % 10;
            //        revNum = revNum * 10;
            //        num = num / 10;
            //    }
            //    revNum = revNum / 10;

            //    if (revNum == origNum) Console.WriteLine($"{origNum} is Pulindrom");
            //    else Console.WriteLine($"{origNum} is not Pulindrom");
            //}

            var array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach(var item in array) { Cons ole.WriteLine(item); }

            Console.WriteLine("Введите число для проверки на полиндромность: ");
            int numb = Convert.ToInt32(Console.ReadLine());

            //Polindrom(numb);


        }
    }
}

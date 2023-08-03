using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsCsharp.Seminars
{
    public static class S5p1
    {
        /// <summary>
        /// Одномерные массивы
        /// </summary>
        public static void Launch()
        {
            // Первый вид методов - генерирующие.
            // Второй - аналитические.
            //Третий - преобразующий.

            // Задайте массив из m элементов, заполненный случайными числами из промежутка [a, b]. Найдите сумму отрицательных элементов массива.

            int[] CreateRandomArray(int size, int minValue, int maxValue)
                {
                    int[] array = new int[size]; //выделение памяти: тип(инт), название и new int[размер массива]. инициализвция рабочей переменной, существующей только внутри цикла. в случае с массивами - это переменная индекса. 
                    for (int i = 0; i < size; i++) // Первый блок может и отсутствовать, НО! его точку с запятой в начале оставляем.
                    {
                        array[i] = new Random().Next(minValue, maxValue + 1);                           //второй блок - это логическое условие существования цикла(то что в while пишем обычно. 
                    }                           // Третий блок - это процесс направленный на изменение рабочей пременной. Блоки можно расширять через запятую.
                    return array;
                }

            void WriteArray(int[] array)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    Console.WriteLine();
                }

                
            int SumNegNum (int[] array1)
                {
                    int sum = 0;
                    for (int i = 0; i < array1.Length; i++)
                
                        if (array1[i] < 0) sum = sum + array1[i];
                return sum;
                
                }

            Console.Write("Enter a length of an array: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int[] myArray = CreateRandomArray(m, a, b);
            WriteArray(myArray);
            Console.WriteLine(SumNegNum(myArray));

            



        }
    }
}

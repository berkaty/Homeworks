using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число натуральное число");
            var b = int.Parse(Console.ReadLine());
            var myarray = new int[15];
            for (var i = 0; i < 15; i++)
                myarray[i] = DegreeOfTwo(i) - b;

            Console.WriteLine("Массив через ;");
            PrintArraySeparatedBySemicolons(myarray);
            Console.WriteLine();
            Console.WriteLine("Массив с измененным знаком у элементов с нечетным индексом");
            PrintChangedArray(myarray);
            Console.WriteLine();
            Console.WriteLine("Cреднее арифметическое элементов массива");
            TheArithmeticMean(myarray);
            Console.WriteLine();
            Console.WriteLine("Массив остатков от деления");
            PrintTheRemainders(myarray);
            Console.ReadKey();
        }

        static int DegreeOfTwo(int n)
        {
            var degree = 1;
            for (var i = 0; i < n; i++)
                degree *= 2;
            return degree;
        }

        static void PrintArraySeparatedBySemicolons(int[] myarray)
        {
            for (var i = 0; i < myarray.Length; i++)
                Console.Write($"{myarray[i]}; ");
        }

        static void PrintChangedArray(int[] myarray)
        {
            int n = 0;
            for (int i = 0; i < 15; i++)
            { 
                n = i;
                if (n % 2 == 0)
                    Console.Write($"{myarray[n]}; ");
                else
                {
                    myarray[n] *= (-1);
                    Console.Write($"{myarray[n]}; ");
                }
            }
        }

        static void TheArithmeticMean(int[] myarray)
        {
            double summ = 0;
            for (var i = 0; i < myarray.Length; i++)
            {
                summ += myarray[i];
            }
            double thearithmeticmean = summ / myarray.Length;
            Console.WriteLine(Math.Round(thearithmeticmean, 3));
        }

        static void PrintTheRemainders(int[] myarray)
        {
            Console.WriteLine("\r\nВведите целое число");
            var k = int.Parse(Console.ReadLine());
            var remaindersArray = new int[15];
            for (var i = 0; i < 15; i++)
            {
                var RemainderOfTheDivision = myarray[i] % k;
                remaindersArray[i] = RemainderOfTheDivision;
                Console.Write($"{remaindersArray[i]}; ");
            }
        }
    }
}
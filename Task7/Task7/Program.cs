using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    //Каждое из чисел m и n нечетное. 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа");
 
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenOdd(m, n));

        }
        private static string EvenOdd (int m, int n)
        {
            if ((m % 2 != 0) && (n % 2 != 0))
                return ("Каждое из чисел нечетное.");
            else
                return ("НЕ каждое из чисел нечетное.");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task92
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число, большее 1");
            double a = double.Parse(Console.ReadLine());
            var check = true;
            while (check)
            {
                check = a <= 1;
                if (!check)
                    break;
                Console.WriteLine("Введите верное значение");
                a = double.Parse(Console.ReadLine());
            }

            double summ = 0;
            var number = 0;

            for (int n = 1; n < 10000; n++)
            {
                summ += (1 / Math.Sqrt(n));
                if (summ > a)
                {
                    number = n;
                    break;
                }
            }
            Console.WriteLine($"Наименьшее число n={number}");
        }
    }
}

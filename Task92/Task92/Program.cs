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

            if (a<=1)
                do
                {
                    Console.WriteLine("Введите верное значение");
                    a = double.Parse(Console.ReadLine());
                } while (a <= 1);

            double summ = 0;
            var number = 0;
            int n = 1;
            var i = true;

            do
            {
                summ += (1 / Math.Sqrt(n));
                if (summ > a)
                {
                    number = n;
                    break;
                }
                n += 1;
            } while (i);

            Console.WriteLine($"Наименьшее число n={number}");
        }
    }
}

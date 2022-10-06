using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба");
            double a = double.Parse(Console.ReadLine());

            double v = a * a * a;
            double diagonal = a * (Math.Sqrt(3));

            Console.WriteLine("Объем куба:" + v);
            Console.WriteLine("Диагональ куба:"+ diagonal);
            Console.ReadKey();
        }
    }
}

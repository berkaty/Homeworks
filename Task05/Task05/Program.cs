using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine(Math.Round( Square(2 + Square(3 + Square(4 + Square(5)))),3));
        }

        public static double Square(double x)
        {
            return Math.Sqrt(x);
        }
    }
}

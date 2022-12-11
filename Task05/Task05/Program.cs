using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(Result(x));
        }
        public static double Result(int x)
        {
            double y=x;
            while (x>2)
            {
                y= (x-1)+Math.Sqrt(y);
                x = x - 1;
            }
            return (y);
        }
    }
}

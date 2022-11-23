using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x и y");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(TrueFalse(x, y));
            Console.ReadKey();  

        }
        private static bool TrueFalse(int x, int y)
        {
            if ((x >= 2) && (y >= 0))
                return true;
            else if ((x >= 1) && (y <= -1))
                return true;
            else
                return false;

        }
    }
    
}

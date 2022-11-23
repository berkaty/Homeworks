using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            string x = Console.ReadLine();
            double y = double.Parse(x);
            Console.WriteLine(Function(y));
            Console.ReadKey();
        }

        static double Function(double x)
        {
            if (x > 2)
                return (2);
            else if (0 < x)
            {
                if (x <= 2)
                    return 0;
                else
                    return (-3 * x);
            }
            else
                return x;
 
        }
        
    }
}

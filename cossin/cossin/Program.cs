using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cossin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angle1 = 15*Math.PI/180; 
        
            Console.WriteLine( "sin(15) = "+ Math.Round(Math.Sin(angle1),3));
            Console.WriteLine("cos(15) = " + Math.Round(Math.Cos(angle1), 3));

            double angle2 = 37 * Math.PI / 180;

            Console.WriteLine("sin(37) = " + Math.Round(Math.Sin(angle2), 3));
            Console.WriteLine("cos(37) = " + Math.Round(Math.Cos(angle2), 3));

            double angle3 = 113 * Math.PI / 180;

            Console.WriteLine("sin(113) = " + Math.Round(Math.Sin(angle3), 3));
            Console.WriteLine("cos(113) = " + Math.Round(Math.Cos(angle3), 3));

            Console.ReadKey();

        }
    }
}

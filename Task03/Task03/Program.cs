using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите час");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минуту");
            int minute = int.Parse(Console.ReadLine());

            if (hour == minute)
            {
                Console.WriteLine(minute);
            }
            else if ( hour > minute)
            {
                Console.WriteLine(hour - minute);
            }
            else if (hour < minute)
            {
                Console.WriteLine(60 - minute + hour + 1);
            }

            Console.ReadKey();
        }
    }
}

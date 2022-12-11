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

            //Скорость часовой стрелки = 360 / (12 * 60) = 0.5
            //Скорость минутной стрелки = 360 / 60 = 6 
            //Отсюда формула: 0.5 (60*hour + minute) = 6*minute  -> minute= 30 * hour / 5.5
            if (((30 * hour / 5.5) - minute) < 0)
            {
                double Result = Math.Ceiling(30 * (hour + 1) / 5.5) - minute + 60;
                Console.WriteLine($"Стрелки встретятся через {(Result)} минут");
            }
            else
            {
                double Result = Math.Ceiling(30 * hour / 5.5) - minute;
                Console.WriteLine($"Стрелки встретятся через {(Result)} минут") ;
            }
            Console.ReadKey();
        }
    }
}

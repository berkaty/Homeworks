using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task91
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число, не равное 0");
            int b = int.Parse(Console.ReadLine());
            var check = true;
            while (check)
            {
                check = b == 0;
                if (!check)
                    break;
                Console.WriteLine("Введите верное значение");
                b = int.Parse(Console.ReadLine());
            }
            int summ = 0;
            for (int i = -b; i <= b * b; i++)
            {
                summ += i * i;
            }
            Console.WriteLine($"Сумма квадратов всех целых чисел от -{b} до ({b} в квадрате) = {summ}");
        }
    }
}

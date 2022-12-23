using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            int Number = int.Parse(Console.ReadLine());
            int Number1 = Number;
            int MaxNumber = 0;
            int NumberOfDigits = 1;
            do
            {
                MaxNumber = Math.Max(Number % 10, MaxNumber);
                Number /= 10;
                NumberOfDigits += 1;
            }
            while ((Number / 10) > 0);

            int OrderNumber = NumberOfDigits;
            int NumberOfDigits1 = NumberOfDigits;
            for (int i = 0; i <= NumberOfDigits1; i++)
            {
                if ((Number1 % 10) == MaxNumber)
                    OrderNumber = NumberOfDigits;

                NumberOfDigits -= 1;
                Number1 /= 10;
            }
            Console.WriteLine($"Порядковый номер первой наибольшей цифры в числе = {OrderNumber}");
        }
    }
}

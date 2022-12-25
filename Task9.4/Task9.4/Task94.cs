using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task94
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральные числа а и b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a>=b)
                do
                {
                    Console.WriteLine("Введите верные значения");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                } while (a >= b);
            NumberOfDivisors(a, b);
        }

        static void NumberOfDivisors(int a,int b)
        {
            Console.WriteLine("Введите количество делителей");
            int k = int.Parse(Console.ReadLine());
            int numberofdivisors = 0;

            if (k<2)
                do
                {
                    Console.WriteLine("Введите верное значение");
                    k = int.Parse(Console.ReadLine());
                } while (k < 2);

            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i % j) == 0)
                        if ((numberofdivisors + 1) >=k)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        else
                            numberofdivisors += 1;
                }
                numberofdivisors = 0;
            }
        }
    }
}

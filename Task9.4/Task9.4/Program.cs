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
            int k = 0;
            var check = true;
            while (check)
            {
                check = a >= b;
                if (!check)
                    break;
                Console.WriteLine("Введите верное значение");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            }
            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i % j) == 0)
                        if ((k + 1) >= 2)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        else
                            k += 1;
                }
            }
        }
    }
}

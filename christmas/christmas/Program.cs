
using System;

namespace pr11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Все простые циклические числа до 1000000:");

            for (int i = 2; i < 1000000; i++)
            {
                string str = i.ToString();
                string[] arr = str.Split();

            }

            Console.ReadLine();
        }

        static bool SimpleNumberOrNot(int num)
        {
            bool flag = true;
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            return (flag);
        }
    }
}

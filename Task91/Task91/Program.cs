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
                if (b == 0)
                {
                    Console.WriteLine("Неверное введенное значение");
                    return;
                }
                int Summ = 0;
                for (int i = -b; i <= b * b; i++)
                {
                    Summ += i * i;
                }
                Console.WriteLine(Summ);
            }
        }
    }

}
    }
}

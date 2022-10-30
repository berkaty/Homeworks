using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Дано слово «трос», получить слова «сорт» и «рост».
            string a = "трос";
            Console.WriteLine(a.Substring(3, 1) + a.Substring(2, 1) + a.Substring(1, 1) + a.Substring(0, 1));
            Console.WriteLine(a.Substring(1, 3) + a.Substring(0, 1));

            Console.ReadKey();
        }
    }
}

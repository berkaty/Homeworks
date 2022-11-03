using System;
using static System.Net.Mime.MediaTypeNames;

namespace Task061
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(Replacement());

        }
        public static string Input()
        {
            Console.WriteLine("Введите текст: ");
            string text=Console.ReadLine();
            text=text.ToUpper();
            return text;
            
            
        }

        public static string Replacement()
        {

            string text1 = Input();
            text1=text1.Replace('А', 'A');
            text1 = text1.Replace('Б', '6');
            text1 = text1.Replace("В", "B");
            text1 = text1.Replace("Г", "r");
            text1 = text1.Replace("Д", "r");
            text1 = text1.Replace("Е", "E");
            text1 = text1.Replace("Ё", "E");
            text1 = text1.Replace("Ж", "}|{");
            text1 = text1.Replace("З", "3");
            text1 = text1.Replace("И", "u");
            text1 = text1.Replace("Й", "u*");
            text1 = text1.Replace("К", "K");
            text1 = text1.Replace("Л", "JI");
            text1 = text1.Replace("М", "M");
            text1 = text1.Replace("Н", "H");
            text1 = text1.Replace("О", "0");
            text1 = text1.Replace("П", "n");
            text1 = text1.Replace("Р", "P");
            text1 = text1.Replace("С", "C");
            text1 = text1.Replace("Т", "T");
            text1 = text1.Replace("У", "Y");
            text1 = text1.Replace("Ф", "cp");
            text1 = text1.Replace("Х", "X");
            text1 = text1.Replace("Ц", "L|");
            text1 = text1.Replace("Ч", "4");
            text1 = text1.Replace("Ш", "LLI");
            text1 = text1.Replace("Щ", "LLL");
            text1 = text1.Replace("Ъ", "'b");
            text1 = text1.Replace("Ы", "bI");
            text1 = text1.Replace("Ь", "b");
            text1 = text1.Replace("Э", "-)");
            text1 = text1.Replace("Ю", "IO");
            text1 = text1.Replace("Я", "9I");
            return text1;
            
        }

        
    }
}

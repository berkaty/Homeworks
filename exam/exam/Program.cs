using System;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int degree = int.Parse(Console.ReadLine());

            for (int i = 10; i < 1000000000; i++)
            {
                int number = i;
                int[] myarray = new int[number.ToString().Length];
                int sumofdegrees = 0;
                
                for (int j = 0; j < myarray.Length; j++)
                {
                    myarray[j] = number % 10;
                    number /= 10;
                }

                for (int j=0; j < myarray.Length; j++)
                    sumofdegrees += Degree(myarray[j], degree);
                if (sumofdegrees == i)
                    Console.WriteLine($"Число {i} равно сумме {degree}-х степеней своих цифр");
            }
            Console.ReadKey();
        }

        static int Degree(int number, int n)
        {
            int number1 = number;
            for (int i = 1; i < n; i++)
                number *= number1;
            return number;
        }
    }
}
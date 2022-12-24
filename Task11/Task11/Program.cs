using System;
namespace Table
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число строк таблицы");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов таблицы");
            var n = int.Parse(Console.ReadLine());

            var check = true;
            while (check)
            {
                check = (m <= 5 || m >= 20 || n <= 5 || n >= 20);
                if (!check)
                    break;
                Console.WriteLine("Введите верные значения для строк и столбцов");
                m = int.Parse(Console.ReadLine());
                n = int.Parse(Console.ReadLine());
            }

            var table = new int[m, n];
            var rnd = new Random();
            for (var i = 0; i < table.GetLength(0); i++)
                for (var j = 0; j < table.GetLength(1); j++)
                    table[i, j] = rnd.Next(100);
            PrintTable(table);
            IsOrdered(table);
            SumOfOddElements(table);
            Console.ReadKey();
        }
        static void PrintTable(int[,] t)
        {
            for (var i = 0; i < t.GetLength(0); i++)
            {
                for (var j = 0; j < t.GetLength(1); j++)
                    Console.Write($"{t[i, j],2} ");

                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void IsOrdered(int[,] table)
        {
            var TF = true;
            for (var i = 0; i < table.GetLength(0); i++)
            {
                for (var j = 0; j < table.GetLength(1) - 1; j++)
                    if (table[i, j] < table[i + 1, j])
                    {
                        Console.WriteLine("значения индексов строк и столбцов: " +i+ " " + j+"; "+ (i+1)+" "+j);
                        TF = false;
                        break;
                    }
                if (!TF)
                    break;
                if (TF)
                    Console.WriteLine("Строки массива упорядочены по возрастанию");
            }
        }
        static void SumOfOddElements(int[,] t)
        {
            for (var i = 0; i < t.GetLength(1); i++)
            {
                var summ = 0;
                for (var j = 0; j < t.GetLength(0); j++)
                {
                    if (t[j,i] % 2 != 0)
                        summ += t[j,i];
                }
                Console.WriteLine("индекс столбца "+(i+1) + " сумма = " + summ);
            }
        }
    }
}

using System;

namespace _3_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 7;
            int i, j;
            Console.WriteLine("1)");
            int[,] array = new int[length, length];
            Random random = new Random();
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 50);
                    Console.Write($"{array[i, j], -3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n2)");
            for (j = 0; j < array.GetLength(0); j++)
            {
                for (i = array.GetLength(1) - 1; i >= 0; i--)
                {
                    Console.Write($"{array[i, j], -3}");
                }
                Console.WriteLine();
            }
        }
    }
}

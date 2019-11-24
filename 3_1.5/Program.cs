using System;

namespace _3_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Матрица А:");
            int length = 5;
            int[,] array = new int[length, length];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 9);
                    Console.Write($"{array[i, j], -3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nМатрица B:");
            int length_1 = 5;
            int[,] array_1 = new int[length_1, length_1];
            Random random_1 = new Random();
            for (int i = 0; i < array_1.GetLength(0); i++)
            {
                for (int j = 0; j < array_1.GetLength(1); j++)
                {
                    array_1[i, j] = random_1.Next(0, 9);
                    Console.Write($"{array_1[i, j], -3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nМатрица A * B:");
            int x = 0;
            int lenght_2 = 5;
            int[,] array_2 = new int[lenght_2, lenght_2];
            for (int i = 0; i < array_2.GetLength(0); i++)
            {
                for (int j = 0; j < array_2.GetLength(1); j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        x += array[k, j] * array_1[i, k];
                    }
                    array_2[i, j] = x;
                    x = 0;
                    Console.Write($"{array_2[i, j], -5}");
                }
                Console.WriteLine();
            }
        }
    }
}

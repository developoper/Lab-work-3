using System;

namespace _3_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 3;
            Console.WriteLine("Матрица А:");
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
            int length_1 = 3;
            Console.WriteLine("\nМатрица В:");
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
            Add(array, array_1, 0);
            Sub(array, array_1, 0);
        }
        public static void Add(int[,] array, int[,] array_1, int mean)
        {
            Console.WriteLine("\nМатрица A + B:");
            int[,] sumofArray = new int[3, 3];
            int x = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumofArray[i, j] = array[i, j] + array_1[i, j];
                    x += sumofArray[i, j];
                    Console.Write($"{sumofArray[i, j], -3}");
                }
                Console.WriteLine();
            }
            Console.Write("Среднее значение: " + x / 9);
        }
        public static void Sub(int[,] array, int[,] array_1, int mean)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Матрица A - B:");
            int[,] diffofArray = new int[3, 3];
            int y = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    diffofArray[i, j] = array[i, j] - array_1[i, j];
                    y += diffofArray[i, j];
                    Console.Write($"{diffofArray[i, j], -5}");
                }
                Console.WriteLine();
            }
            Console.Write("Среднее значение: " + y / 9);
        }
    }
}

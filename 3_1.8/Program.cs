using System;

namespace _3_1._8
{
    class Program
    {
        static void Main()
        {
            int error = 0;
            while (error == 0)
            {
                try
                {
                    int X = 0, Y = 0;
                    Console.WriteLine("Введите размерность матрицы:");
                    X = Convert.ToInt32(Console.ReadLine());
                    Y = Convert.ToInt32(Console.ReadLine());
                    if (X == Y)
                    {
                        error = 1;
                        double[,] array = new double[X, Y];
                        Random random = new Random();
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                array[i, j] = random.Next(0, 9);
                                Console.Write($"{array[i, j],-3}");
                            }
                            Console.WriteLine();
                        }
                        var det = DetRec(array);
                        Console.Write("Определитель равен: " + det);
                    }
                    else
                    {
                        error = 0;
                        Console.WriteLine("Ошибка. Пожалуйста, введите корректные данные." + "\n ");
                    }
                }
                catch (FormatException)
                {
                    error = 0;
                    Console.WriteLine("Ошибка. Пожалуйста, введите корректные данные." + "\n ");
                }
            }
        }
        private static double DetRec(double[,] array)
        {
            if (array.Length == 4)
            {
                return array[0, 0] * array[1, 1] - array[0, 1] * array[1, 0];
            }
            double sign = 1, result = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                double[,] minor = GetMinor(array, i);
                result += sign * array[0, i] * DetRec(minor);
                sign = -sign;
            }
            return result;
        }
        private static double[,] GetMinor(double[,] array, int n)
        {
            double[,] result = new double[array.GetLength(0) - 1, array.GetLength(0) - 1];
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < n; j++)
                    result[i - 1, j] = array[i, j];
                for (int j = n + 1; j < array.GetLength(0); j++)
                    result[i - 1, j - 1] = array[i, j];
            }
            return result;
        }
    }
}

using System;

namespace _3_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int error = 0;
            while (error == 0)
            {
                try
                {
                    error = 1;
                    Console.Write("Введите количество элементов массива: ");
                    int lenght = Convert.ToInt32(Console.ReadLine());
                    int[] array = new int[lenght];
                    Random random = new Random();
                    for (int i = 0; i < lenght; i++)
                    {
                        array[i] = random.Next(-15, 15);
                        Console.Write(array[i] + " ");
                    }
                    bool ind = false;
                    foreach (int num in array)
                    {
                        foreach (int num_1 in array)
                        {
                            if (Math.Abs(num) == Math.Abs(num_1) && Math.Abs(num) - Math.Abs(num_1) == 5 || Math.Abs(num_1) - Math.Abs(num) == 5)
                            {
                                ind = true;
                                Console.Write("\nПара: " + Math.Abs(num) + ", " + Math.Abs(num_1));
                            }
                        }
                    }
                    if (ind == false)
                    {
                        Console.Write("\nТаких пар в массиве нет.");
                    }
                }
                catch (FormatException)
                {
                    error = 0;
                    Console.WriteLine("Ошибка. Пожалуйста, введите корректные данные." + "\n ");
                }
            }
        }
    }
}

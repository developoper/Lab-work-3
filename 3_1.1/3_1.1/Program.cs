using System;

namespace _3_1._1
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
                    int num = Convert.ToInt32(Console.ReadLine());
                    int[] array = new int[num];
                    Random random = new Random();
                    for (int i = 0; i < num; i++)
                    {
                        array[i] = random.Next(-30, 45);
                        Console.Write(array[i] + " ");
                    }
                    foreach (int element in array)
                    {
                        if (element > 0)
                        {
                            Console.Write("\nРезультат: " + element);
                        }
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

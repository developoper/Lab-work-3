using System;

namespace _3_1._3
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
                    Console.WriteLine("Массив без сдвига:");
                    int[] array = new int[10];
                    Random random = new Random();
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(0, 11);
                    }
                    Console.WriteLine(string.Join(" ", array));
                    Console.Write("Введите число k: ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Массив со сдвигом:");
                    int temp = array[array.Length - k];
                    for (int i = array.Length - k; i > array.Length; i--)
                    {
                        array[i] = array[i - k];
                    }
                    array[0] = temp;
                    Console.WriteLine(string.Join(" ", array));
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

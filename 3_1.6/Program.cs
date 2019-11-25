using System;


namespace _3_1._6
{
    class Program
    {
        static int sumIterative(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int sumRecursive (int [] array, int Leght)
        {
            if (Leght > 0)
            {
                return array[Leght - 1] + sumRecursive(array, Leght - 1);
            }
            else
            {
                return 0;
            }
        }
        static int minIterative (int [] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int minRecursive (int[] array, int Leght)
        {
            if (Leght <= 0)
            {
                return Int32.MaxValue;
            }
            return Math.Min(array[Leght - 1], minRecursive(array, Leght - 1));
        }
        static void Main(string[] args)
        {
            int[] array = new int[10]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };
            Console.WriteLine("Числа массива: " + "\n" + string.Join(" ", array));

            Console.WriteLine("Пример sumIterative:");
            int sumIter = sumIterative(array);
            Console.WriteLine(sumIter);

            Console.WriteLine("Пример minIterative:");
            int minIter = minIterative(array);
            Console.WriteLine(minIter);

            Console.WriteLine("Пример sumRecursive:");
            int sumRec = sumRecursive(array, array.Length);
            Console.WriteLine(sumRec);

            Console.WriteLine("Пример minRecursive:");
            int minRec = minRecursive(array, array.Length);
            Console.WriteLine(minRec);
        }
    }
}

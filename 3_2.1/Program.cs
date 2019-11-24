using System;

namespace _3_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Спиральная мартица: ");
            const int length = 9, length_1 = 9;
            int[,] array = new int[length, length_1];
            int n = length, m = length_1, c = 0, i = 0, j = 0, k = 0;
            while (k < length * length_1)
            {
                for (j = c; j < m; j++)
                {
                    if (k == length * length_1)
                        break;
                    array[i, j] = k;
                    k++;
                }
                j--;
                for (i = c + 1; i < n; i++)
                {
                    if (k == length * length_1)
                        break;
                    array[i, j] = k;
                    k++;
                }
                i--;
                for (j = m - 2; j >= c; j--)
                {
                    if (k == length * length_1)
                        break;
                    array[i, j] = k;
                    k++;
                }
                j++;
                for (i = n - 2; i >= c + 1; i--)
                {
                    if (k == length * length_1)
                        break;
                    array[i, j] = k;
                    k++;
                }
                c++;
                n--;
                m--;
                i = c;
            }
            for (i = 0; i < length; i++)
            {
                for (j = 0; j < length_1; j++)
                {
                    Console.Write($"{array[i, j], -3}");
                }
                Console.WriteLine();
            }
        }
    }
}

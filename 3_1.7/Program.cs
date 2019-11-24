using System;

namespace _3_1._7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int error = 0;
            while (error == 0)
            {
                try
                {
                    error = 1;
                    Console.Write("Введите n-ый член: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Он равен: " + Fib(n));
                }
                catch (FormatException)
                {
                    error = 0;
                    Console.WriteLine("Ошибка. Пожалуйста, введите корректные данные." + "\n ");
                }
            }
        }
        public static int Fib(int term, int val = 1, int prev = 0)
        {
            if (term == 0)
            {
                return prev;
            }
            if (term == 1)
            {
                return val;
            }
            return Fib(term - 1, val + prev, val);
        }
    
    }
}

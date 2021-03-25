using System;

namespace Problem3258
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            Console.WriteLine(fib[n]);
        }
    }
}
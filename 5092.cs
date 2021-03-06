using System;

namespace Problem5091
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            uint[] fib = new uint[n + 2];
            fib[1] = 2;
            fib[2] = 3;
            for (int i = 3; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            Console.WriteLine(fib[n]);
        }
    }
}
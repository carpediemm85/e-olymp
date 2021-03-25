using System;
using System.Numerics;

namespace Problem5198
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string setir = Console.ReadLine();
            var massiv = setir.Split(' ');
            int a = int.Parse(massiv[0]);
            int b = int.Parse(massiv[1]);
            int m = int.Parse(massiv[2]);
            Console.WriteLine(BigInteger.ModPow(a, b, m));
        }
    }
}
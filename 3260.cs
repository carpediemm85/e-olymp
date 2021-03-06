using System;

namespace Problem3260
{
    internal class Program
    {
        private static long Kombinezon(int n, int k)
        {
            int max = Math.Max(k, n - k) + 1;
            int min = Math.Min(k, n - k);
            long cavab = 1;
            for (int i = max; i <= n; i++) cavab = cavab*i;
            for (int i = min; i > 1; i--) cavab = cavab/i;
            return cavab;
        }

        public static void Main(string[] args)
        {
            string setir = Console.ReadLine();
            var massiv = setir.Split(' ');
            int n = int.Parse(massiv[0]);
            int k = int.Parse(massiv[1]);
            Console.WriteLine(Kombinezon(n, k));
        }
    }
}
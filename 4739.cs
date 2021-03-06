using System;

namespace Problem4739
{
    internal class Program
    {
        private static bool Sade(int x)
        {
            if ((x == 0) || (x == 1)) return false;
            if ((x == 2) || (x == 3)) return true;
            if (x%2 == 0) return false;
            int kok = (int) Math.Sqrt(x) + 1;
            for (int i = 3; i < kok; i = i + 2)
            {
                if (x%i == 0) return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            string setir = Console.ReadLine();
            var massiv = setir.Split(' ');
            int a = int.Parse(massiv[0]);
            int b = int.Parse(massiv[1]);
            setir = "";
            for (int i = a; i <= b; i++)
            {
                if (Sade(i)) setir = setir + i + " ";
            }
            setir = setir.TrimEnd(' ');
            Console.WriteLine(setir);
        }
    }
}
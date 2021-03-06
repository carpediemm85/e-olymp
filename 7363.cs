using System;

namespace Problem7363
{
    internal class Program
    {
        private static int EBOB(int x, int y)
        {
            while (x*y != 0)
            {
                if (x < y) y = y%x;
                else x = x%y;
            }
            return x + y;
        }

        public static void Main(string[] args)
        {
            string setir = Console.ReadLine();
            var massiv = setir.Split(' ');
            int a = int.Parse(massiv[0]);
            int b = int.Parse(massiv[1]);
            int c = int.Parse(massiv[2]);
            int d = int.Parse(massiv[3]);
            int suret = a*d + b*c;
            int mexrec = b*d;
            int ebob = EBOB(suret, mexrec);
            suret = suret/ebob;
            mexrec = mexrec/ebob;
            if (mexrec == 1) Console.WriteLine(suret);
            else Console.WriteLine("{0} {1}", suret, mexrec);
        }
    }
}
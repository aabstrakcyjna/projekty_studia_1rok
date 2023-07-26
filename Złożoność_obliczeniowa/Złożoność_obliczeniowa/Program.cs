using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Złożoność_obliczeniowa
{
    internal class Program
    {
        public static BigInteger sumaO1(ulong n)
        {
            BigInteger wynik = n * (n + 1) / 2;
            return wynik;
        }
        public static BigInteger sumaOn(ulong n)
        {
            BigInteger wynik = 0;
            for (ulong i = 1; i <= n; i++)
                wynik += i;
            return wynik;
        }
        public static BigInteger sumaOn2(ulong n)
        {
            BigInteger wynik = 0;
            for (ulong i = 1; i <= n; i++)
                for (ulong j = 1; j <= i; j++)
                    wynik++;
            return wynik;
        }
        static void Main(string[] args)
        {
            ulong[] tablica = { 1000, 1000000, 1000000000, 1000000000000 };
            Stopwatch stoper;
            foreach (ulong n in tablica)
            {
                stoper = new Stopwatch();
                stoper.Start();
                BigInteger wynik = sumaO1(n);
                stoper.Stop();
                Console.WriteLine("Dla O(1) n = " + n + ", suma = " + wynik + ", czas: " + stoper.Elapsed.TotalMilliseconds + "ms");
            }
            foreach (ulong n in tablica)
            {
                stoper = new Stopwatch();
                stoper.Start();
                BigInteger wynik = sumaOn(n);
                stoper.Stop();
                Console.WriteLine("Dla O(n) n = " + n + ", suma = " + wynik + ", czas: " + stoper.Elapsed.TotalMilliseconds + "ms");
            }
            foreach (ulong n in tablica)
            {
                stoper = new Stopwatch();
                stoper.Start();
                BigInteger wynik = sumaOn2(n);
                stoper.Stop();
                Console.WriteLine("Dla O(n^2) n = " + n + ", suma = " + wynik + ", czas: " + stoper.Elapsed.TotalMilliseconds + "ms");
            }
            Console.ReadLine();
        }
    }
}

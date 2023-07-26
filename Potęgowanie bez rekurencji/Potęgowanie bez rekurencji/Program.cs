using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potęgowanie_bez_rekurencji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę a: ");
            double a= double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            double b = double.Parse(Console.ReadLine());
            double wynik = 1;
            while (b > 0)
            {
                wynik *= a;
                b--;
            }
            Console.WriteLine("Wynik potęgowania to: "+wynik+"");
            Console.ReadLine();

        }
    }
}

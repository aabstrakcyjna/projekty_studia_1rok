using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Największy_wspólny_dzielnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            double a =double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę");
            double b = double.Parse(Console.ReadLine());
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            Console.WriteLine("Największy wspólny dzielnik to " + a + "");
            Console.ReadLine(); 
        }
    }
}

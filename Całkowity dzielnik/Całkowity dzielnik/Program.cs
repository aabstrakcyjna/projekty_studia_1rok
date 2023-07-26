using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Całkowity_dzielnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dzielną");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj dzielnik");
            double b = double.Parse(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("Liczba "+ b + " jest całkowitym podzielnikiem " + a + ".");
            }
            else
            {
                Console.WriteLine("Liczba " + b + " nie jest całkowitym podzielnikiem " + a + ".");
            }
            Console.ReadLine();
        } 
    }
}

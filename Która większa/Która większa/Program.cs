using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Która_większa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Liczba "+a+ " jest większa od "+b+ ".");
            }
            else
            {
                Console.WriteLine("Liczba " + b + " jest większa od " + a + ".");
            }
            Console.ReadLine();
        }
    }
}

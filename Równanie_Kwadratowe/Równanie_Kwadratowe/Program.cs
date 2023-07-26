using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Równanie_Kwadratowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Pamiętaj, że a,b,c muszą być liczbami całkowitymi");
            Console.WriteLine();
            Console.WriteLine("Podaj wartość dla a: ");
            string _a = Console.ReadLine();
            a = int.Parse(_a);
            Console.WriteLine("Podaj wartość dla b: ");
            string _b = Console.ReadLine();
            b = int.Parse(_b);
            Console.WriteLine("Podaj wartość dla c: ");
            string _c = Console.ReadLine();
            c = int.Parse(_c);

            int delta = (b*b) - (4*a*c);
            Console.WriteLine("Wartość delty to: " + delta);
            if (delta < 0)
            {
                Console.WriteLine("To równanie nie ma rzeczywistych pierwiastków");
            }
            else if (delta == 0)
            {
                double x = (-1 * b) / (2 * a);

                Console.WriteLine("To równanie ma jeden rzeczywisty pierwiastek: " + x);

            }
            else 
            {
                double x1 = ((-1 * b) - Math.Sqrt(delta))/ (2 * a);
                double x2 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("To równanie ma dwa rzeczywiste pierwiastki: " + x1 + ", " + x2);

            }
            Console.ReadLine();




           



        }
    }
}

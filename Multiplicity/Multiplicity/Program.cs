using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Podaj dwie różne od siebie liczby");
            Console.WriteLine("Podaj a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            double b = double.Parse(Console.ReadLine());

            if (a>b)
            {
                x = a / b;
               
                Console.WriteLine("Liczba " + b + " mieści się w liczbie " + a + " " + Math.Floor(x) + " razy");
            }
            else
            {
                y = b/ a;
                Console.WriteLine("Liczba " + a + " mieści się w liczbie " + b + ": " + Math.Floor(y) + " razy");
            }
            Console.ReadLine();
        }   

    }
}

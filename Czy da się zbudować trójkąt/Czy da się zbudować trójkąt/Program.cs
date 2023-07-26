using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czy_da_się_zbudować_trójkąt
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            double a, b, c;
            do
            {
                Console.WriteLine("Podaj a");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj b");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c");
                c = double.Parse(Console.ReadLine());
                if (a > 0 && b > 0 && c > 0)
                {
                    break;
                }
                Console.WriteLine("Podane liczby są mniejsze od 0. Podaj inne liczby");

            } while (true);

            if ((a + b > c) && (a + c > b) && (c + b > a))
            {
                Console.WriteLine("Z podanych liczb może powstać trójkąt");
            }
            else
            {
                Console.WriteLine("Z podanych liczb nie może powstać trójkąt");
            }

            Console.ReadLine();
            
        }
    }
}

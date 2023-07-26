using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole_trójkąta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    double a, b, c, p, s;
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

                    if (a + b > c && a + c > b && c + b > a)
                    {
                        p=0.5*(a + b + c);
                        s=Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                        Console.WriteLine("Pole trójkąta o bokach "+a+", "+b+" i " +c+" wynosi "+s+" jednostek kwadratowych");
                    }
                    else
                    {
                        Console.WriteLine("Z podanych wartości nie może powstać trójkąt, więc nie możemy policzyć jego pola");
                    }

                    Console.ReadLine();

                }
            }
        }

    }

}


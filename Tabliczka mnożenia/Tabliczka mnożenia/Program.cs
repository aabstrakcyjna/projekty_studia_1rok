using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabliczka_mnożenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {



                int[,] tablica = new int[11, 11];
                for (int wiersz = 1; wiersz < 11; wiersz++)
                {
                    for (int kolumna = 1; kolumna < 11; kolumna++)
                    {
                        tablica[wiersz, kolumna] = (wiersz) * (kolumna);
                        Console.Write(tablica[wiersz, kolumna]);
                        if (kolumna < 10)
                        {
                            Console.WriteLine("\t");
                        }
                        else
                        {
                            Console.WriteLine();

                        }
                    }
                }
                Console.ReadLine();
            }
        }
    }
}


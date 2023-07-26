using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Liczba_pierwsza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj liczbę:");
            double n =double.Parse(Console.ReadLine());
            double licznik = 2;
            bool pętla=true;
            while(pętla)
            {
                if(licznik>Math.Sqrt(n))
                {
                    Console.WriteLine("Liczba pierwsza");
                    pętla= false;
                }
                else
                {
                    if (n % licznik == 0)
                    {
                        Console.WriteLine("Liczba złożona");
                        pętla= false;
                    }
                    else
                    {
                        licznik = licznik + 1;

                    }
                    
                }
            }
            Console.ReadLine(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wydawanie_reszty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] banknoty = { 200, 100, 50, 20, 10 };
            int najmniejszy_banknot = banknoty.Min ();

            int do_wydania;
            Console.WriteLine("Podaj kwotę do wydania: ");
            string _do_wydania = Console.ReadLine();
            do_wydania = int.Parse(_do_wydania);

            if (do_wydania % najmniejszy_banknot == 0) 
            {
                for (int i = 0; i < 5; i++)
                {
                    int ilosc = do_wydania / banknoty[i];
                    do_wydania -= ilosc * banknoty[i];
                    Console.WriteLine("Wydano " + ilosc +" banknotów "+ banknoty[i]);
                }
                
            }
            else
            {
                Console.WriteLine("Nie można wydać reszty z podanej kwoty");

            }

            Console.ReadLine();



        }
    }
}

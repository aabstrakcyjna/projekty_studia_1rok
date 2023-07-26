using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taryfikator_mandatów
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz obszar w jakim się poruszasz poprzez naciśnięcie odpowiadającej mu litery");
            Console.WriteLine("Strefa zamieszkania naciśnij a");
            Console.WriteLine("Teren zabudowany naciśnij b");
            Console.WriteLine("Teren niezabudowany naciśnij c");
            Console.WriteLine("Teren niezabudowany (druga dwujezdniowa) naciśnij d");
            Console.WriteLine("Droga ekspresowa jednojezdniowa naciśnij e");
            Console.WriteLine("Droga ekspresowa dwujezdniowa naciśnij  f");
            Console.WriteLine("Autostrada g");
            string strefa=Console.ReadLine();
            
            double predkoscmaksymalna;
            switch (strefa)
            {
                case "a":
                    predkoscmaksymalna= 20;
                    break;
                case "b":
                    predkoscmaksymalna = 50;
                    break;
                case "c":
                    predkoscmaksymalna = 90;
                    break;
                case "d":
                    predkoscmaksymalna = 100;
                    break;
                case "e":
                    predkoscmaksymalna = 100;
                    break;
                case "f":
                    predkoscmaksymalna = 120;
                    break;
                case "g":
                    predkoscmaksymalna = 140;
                    break;
                default:
                    Console.WriteLine("Podano złą strefę. Program się zakończy.");
                    Console.ReadLine();
                    Environment.Exit(1);
                    return;
            }

            Console.WriteLine("Podaj prędkość z jaką się poruszasz");
            double prędkość = double.Parse(Console.ReadLine());
            if (prędkość < 0)
            {
                Console.WriteLine("Prędkość nie może być ujemna. Program się zakończy");
                Console.ReadLine();
                Environment.Exit(1);
            }

            double przekroczeniePredkosci = prędkość - predkoscmaksymalna ;
            if (przekroczeniePredkosci <=0)
            {
                Console.WriteLine("Jedziesz z dozwoloną prędkością");
            }
            else
            {  
                Console.WriteLine("Przekroczyłeś prędkość o " + przekroczeniePredkosci + "km/h");

                if (przekroczeniePredkosci <= 10)
                {
                    Console.WriteLine("Otrzymujesz mandat w wysokości 50 zł.");
                }
                else if (przekroczeniePredkosci <= 15)
                {
                    Console.WriteLine("Otrzymujesz mandat w wysokości 100 zł.");
                }
                else if (przekroczeniePredkosci <= 20)
                {
                    Console.WriteLine("Otrzymujesz mandat w wysokości 200 zł.");
                }
                else if (przekroczeniePredkosci <= 25)
                {
                    Console.WriteLine("Otrzymujesz mandat w wysokości 300 zł.");
                }
                else if (przekroczeniePredkosci <= 30)
                {
                    Console.WriteLine("Otrzymujesz mandat w wysokości 400 zł.");
                }
                else if (przekroczeniePredkosci <= 40)
                {
                    Console.WriteLine("Otrzymujesz mandat w wysokości 800 zł.");
                }
                else if (przekroczeniePredkosci <= 50)
                {
                    Console.WriteLine("Otrzymujesz mandat w wysokości 1000 zł.");
                }
                else if (przekroczeniePredkosci <= 60)
                {
                    Console.WriteLine("Otrzymujesz mandat w wysokości 1500 zł.");
                }
                else if (przekroczeniePredkosci <= 70)
                {
                    Console.WriteLine("Otrzymujesz mandat w wysokości 2000 zł.");
                }
                else if (przekroczeniePredkosci > 70)
                {
                    Console.WriteLine("Otrzymujesz mandat w wysokości 2500 zł.");
                }
                if ((strefa == "a" || strefa == "b") && przekroczeniePredkosci >= 50) 
                {
                    Console.WriteLine("Za przekroczenie predkości powyżej 50 km/h w tej strefie twoje prawo jazdy zostaje zatrzymane");
                }
            }
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj z ilu elemntów ma składać się tablica");
            int n=int.Parse(Console.ReadLine());
            int[] tablicaLiczblosowych=new int[n];
            Console.WriteLine("Podaj początek przedziału: ");
            int poczatekPrzedzialu=int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj koniec przedziału");
            int konieckPrzedzialu = int.Parse(Console.ReadLine());
            Random random = new Random();
            int i;
            for (i = 0; i < n; i++) 
            {
                tablicaLiczblosowych[i]= random.Next(poczatekPrzedzialu,konieckPrzedzialu+1);
                Console.WriteLine($"Dla elementu{i} wylosowana liczba z podnaego przedziału to {tablicaLiczblosowych[i]}");
            }
            Console.WriteLine("Podaj elemnet tablicy, który chcesz wypisć:");
            int element = int.Parse(Console.ReadLine());


            Console.ReadLine();


        }
    }
}

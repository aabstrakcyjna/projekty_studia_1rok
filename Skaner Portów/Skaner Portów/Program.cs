using System;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;

namespace Skaner_Portów
{
    class PortScanner
    {
        public static void SprawdzaniePortu(object port_obj) 
        {
            int port = Convert.ToInt32(port_obj);
            try
            {
                TcpClient client = new TcpClient();
                client.Connect("127.0.0.1", port);
                Console.WriteLine("Port {0} jest aktywny.", port);
            }
            catch (Exception)
            {
                Console.WriteLine("Port {0} jest nieaktywny.", port);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zakres potrów, które chcesz sprawdzić");
            Console.WriteLine("Podaj pierwszą liczbę");
            int poczatkowyport = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int koncowyport = int.Parse(Console.ReadLine());
            TcpClient client = new TcpClient();

            Stopwatch stoper= new Stopwatch();
            stoper.Start();
            Thread[] tablica = new Thread[koncowyport - poczatkowyport + 1];
            for (int port = poczatkowyport; port <= koncowyport; port++)
            {
                int index = port - poczatkowyport;
                tablica[index] = new Thread(SprawdzaniePortu);
                tablica[index].Start(port);
            }
            foreach(Thread t in tablica)
            {
                t.Join();
            }
            stoper.Stop();
            Console.WriteLine("Czas wykoanania przypadku użycia wielu wątków: "+stoper.Elapsed.TotalMilliseconds+"ms");
            Console.ReadLine();
        }
    }
}

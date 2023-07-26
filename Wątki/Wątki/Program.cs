using System;
using System.Threading;
using System.IO;


namespace Wątki
{
    internal class Program
    {
        private static StreamWriter plik;

        static void pisanieDopliku()
        { 
            Random generator = new Random();
            int idWątku = Thread.CurrentThread.ManagedThreadId;

            for (int i = 0; i < 5; i++)
            {
                lock (plik)
                {
                    plik.WriteLine("Data i czas zapisu: " + DateTime.Now.ToString()+"; ID wątku: "+ idWątku);
                }

                Thread.Sleep(1000 * generator.Next(1, 6));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość wątków: ");
            int n= int.Parse(Console.ReadLine());

            plik = File.AppendText("out.txt");

            Thread[] tablicaWątków = new Thread[n];
            for(int i = 0; i < n; i++)
            {
                tablicaWątków[i] = new Thread(new ThreadStart(pisanieDopliku));
            }
            foreach(Thread wątek in tablicaWątków)
            {
                wątek.Start();
            }
            foreach (Thread wątek in tablicaWątków)
            {
                wątek.Join();
            }

            plik.Close();
        }
    }
}

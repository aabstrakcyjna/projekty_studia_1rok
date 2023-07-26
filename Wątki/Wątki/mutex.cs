using System;
using System.Threading;
using System.IO;


namespace Wątki
{
    internal class ProgramMutex
    {
        private static Mutex mut = new Mutex();
        static void pisanieDopliku()
        {
            Random generator = new Random();
            int idWątku = Thread.CurrentThread.ManagedThreadId;

            for (int i = 0; i < 5; i++)
            {
                mut.WaitOne();
                StreamWriter plik = File.AppendText("out.txt");
                plik.WriteLine("Data i czas zapisu: " + DateTime.Now.ToString() + "; ID wątku: " + idWątku);
                plik.Close();
                mut.ReleaseMutex();
                Thread.Sleep(1000 * generator.Next(1, 6));
            }
        }
        static void MainMutex(string[] args)
        {
            Console.WriteLine("Podaj ilość wątków: ");
            int n = int.Parse(Console.ReadLine());

            Thread[] tablicaWątków = new Thread[n];
            for (int i = 0; i < n; i++)
            {
                tablicaWątków[i] = new Thread(new ThreadStart(pisanieDopliku));
            }
            foreach (Thread wątek in tablicaWątków)
            {
                wątek.Start();
            }
            foreach (Thread wątek in tablicaWątków)
            {
                wątek.Join();
            }
        }
    }
}

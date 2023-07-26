using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyznaczanie_wartości_n_silnia_
{
     class Program
     {    
        static int error = 0;

        static ulong SilniaRekurencyjnie(ulong i)
            
        {

            try 
            {
                checked
                {
                    if (i <= 1) return 1;
                    else return (i * SilniaRekurencyjnie(i - 1));
                }
            } 
            catch (OverflowException ex)
            {
                error = 1;
                return 0;

            }
        }

        static ulong SilniaIteracyjnie(ulong n)
        {
            checked
            {
                try
                {
                    ulong ret = 1;
                    for (uint i = 1; i <= n; i++) ret *= i;
                    return ret;
                }
                catch (OverflowException e) 
                {
                    error = 1;
                    return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            Console.WriteLine("Pamiętaj, że n, n2 muszą należeć do liczb całkowitych dodatnich ");
            Console.WriteLine();
            Console.WriteLine("Podaj wartość dla n: ");
            ulong n = ulong.Parse(Console.ReadLine());
            error = 0;
            Console.WriteLine("Wartość silni za pomocą funkcji rekurencyjnej: ");
            timer.Start();
            ulong ret = SilniaRekurencyjnie(n);
            
            if (error == 0) Console.WriteLine("n! = " + ret);
            else Console.WriteLine("Błąd przepełnienia");
            timer.Stop();
            Console.WriteLine("Czas pracy: "+timer.Elapsed.TotalMilliseconds+ "ms");
            
            error = 0;

            Console.WriteLine("Podaj wartość dla n2: ");

            ulong n2 = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Wartość silni za pomocą funkcji iteracyjnej: ");
            
            timer = new Stopwatch();
            timer.Start();
            ret = SilniaIteracyjnie(n2);
            timer.Stop();
            
            if (error == 0) Console.WriteLine("n2! = " + ret);
            else Console.WriteLine("Błąd przepełnienia");
            Console.WriteLine("Czas pracy: " + timer.Elapsed.TotalMilliseconds + "ms");
            error = 0;

            Console.ReadLine();



        }

    }
}

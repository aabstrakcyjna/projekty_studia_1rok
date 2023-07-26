using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia_iteracyjnie
{
    internal class Program
    {

        static ulong SilniaIteracyjnie(ulong n)
        {

          ulong ret = 1;
          for (uint i = 1; i <= n; i++) ret *= i;
          return ret;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe dla której chcesz obliczyć silnie: ");
            ulong n =ulong.Parse(Console.ReadLine());
            Console.WriteLine(n+"! = "+SilniaIteracyjnie(n));
            Console.ReadLine();
        }
    } 
}

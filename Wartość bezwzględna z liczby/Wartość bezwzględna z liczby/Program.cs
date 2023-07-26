using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wartość_bezwzględna_z_liczby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź X należące do zbioru liczb rzeczywistych");
            double x = double.Parse(Console.ReadLine());
            if (x>=0)
            {
                Console.WriteLine("Wartość bezwzględna "+x+"");
            }
            else
            {
                Console.WriteLine("Wartość bezwzględna "+-x + "");
            }
            Console.ReadLine();
        }
    }
}

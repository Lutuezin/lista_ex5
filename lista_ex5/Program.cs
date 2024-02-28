using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double a, b, m;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            m = (a * 3.5 + b * 7.5) / 11;

            
            Console.WriteLine("MEDIA = " + String.Format("{0:F5}",m ));
            Console.ReadKey();

        }
    }
}
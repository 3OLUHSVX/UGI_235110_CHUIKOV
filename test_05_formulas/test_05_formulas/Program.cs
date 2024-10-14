using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_05_formulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = F(2, 3) + 1 / (F(5, 7));
            Console.WriteLine(x);   
            Console.ReadKey();
        }
        static double F(double a, double b)
        {
            return (Math.Sin(a) + Math.Sin(b)) / (Math.Cos(a) + Math.Cos(b));
        }
    }
}


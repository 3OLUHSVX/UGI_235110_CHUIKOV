using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_04_math_formulas
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите x");
            var x = double.Parse(Console.ReadLine());
            
            var y = MyFunction(x);
            Console.WriteLine($"f(x)={y}");

            Console.ReadKey();
        }
        static double MyFunction (double x)
        {
            //throw new NotImplementedException();
            return 2*Math.Sin(Math.Sqrt((Math.Pow(x, 2)+4))/2)*Math.Cos((Math.Sqrt(Math.Pow(x, 2)+1))/2);
        }
    }

}

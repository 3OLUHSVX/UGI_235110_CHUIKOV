using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_08_func_f_x_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("f(x)= " + condition(x));

            Console.ReadKey();
        }
        static double condition(double x)
        {
            if (x < -2)
            {
               return Math.Sqrt(Math.Pow(x, 2) + 4);
            }

            else if ((x>=-2) & (x<=1)) 
            {
               return 1/(Math.Pow(x, 2)+1);
            }

            else
            {
               return Math.Sqrt(Math.Pow(x, 2) - 1);
            }
        }
    }
}

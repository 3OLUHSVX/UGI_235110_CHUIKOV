using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_07_2_commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x и y: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Результат: " + dot(x,y));
            Console.ReadKey();
        }
        static bool dot(double x, double y)
        {
            return y >= 1 || y <= -3;
        }
    }
}

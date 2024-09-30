using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_02_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа");
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            var average = (first + second + third)/3;
            var fst = (first *second *third);
            var geom = Math.Pow(fst,1.0/3);
            Console.WriteLine("Среднее арифметическое = " + average);
            Console.WriteLine("Среднее геометрическое = " + geom);
            Console.ReadKey();
        }
    }
}

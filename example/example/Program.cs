using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слагаемое");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Суммма слагаемых равна " + (x+y));
            Console.ReadKey();
        }
    }
}

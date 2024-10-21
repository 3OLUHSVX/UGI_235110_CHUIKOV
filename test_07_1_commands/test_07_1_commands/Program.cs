using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_07_1_commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа m и n");
            double m = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Результат "+TrueFalse(m,n));
            Console.ReadKey();
        }

        static bool TrueFalse(double m, double n)
        {
            return (m*n % 5 == 0) && ((m+n) % 5 != 0);
        }


}
}






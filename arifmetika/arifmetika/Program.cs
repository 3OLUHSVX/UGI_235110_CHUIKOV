using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arifmetika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int number = int.Parse(Console.ReadLine());
            var nmb1 = number / 100;
            var nmb21 = number / 10;
            var nmb2 = nmb21 % 10;
            var nmb3 = number % 10;
            Console.WriteLine("Число x = "+ nmb3+ nmb1 + nmb2);
            Console.ReadKey();
        }
    }
}

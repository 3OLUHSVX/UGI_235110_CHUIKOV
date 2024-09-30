using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angleDegree = 15;
            double angleRadians = angleDegree * Math.PI / 180;
            var sin = Math.Sin(angleRadians);
            var cos = Math.Cos(angleRadians);
            Console.WriteLine("sin(15\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(15\xB0) = " + Math.Round(cos, 3));

            Console.WriteLine();
            angleDegree = 15;
            angleRadians = angleDegree * Math.PI / 180;
            sin = Math.Sin(angleRadians);
            cos = Math.Cos(angleRadians);
            Console.WriteLine("sin(15\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(15\xB0) = " + Math.Round(cos, 3));

            Console.WriteLine();
            angleDegree = 113;
            angleRadians = angleDegree * Math.PI / 180;
            sin = Math.Sin(angleRadians);
            cos = Math.Cos(angleRadians);
            Console.WriteLine("sin(113\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(113\xB0) = " + Math.Round(cos, 3));

            Console.WriteLine();
            Console.WriteLine("Введите угол в градусах");
            angleDegree = double.Parse(Console.ReadLine());
            angleRadians = angleDegree * Math.PI / 180;
            sin = Math.Sin(angleRadians);
            cos = Math.Cos(angleRadians);
            Console.WriteLine("sin(" + angleDegree +"\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(" + angleDegree +"\xB0) = " + Math.Round(cos, 3));



            Console.ReadKey();
        }
    }
}

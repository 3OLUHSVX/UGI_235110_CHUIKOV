using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите натуральное число: "); if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                (int steps, int maxValue) = Posled(number);
                Console.WriteLine("Шаги:" + steps);
                Console.WriteLine("Максимальное число:" + maxValue);
            }
            else
            {
                Console.WriteLine("Введите НАТУРАЛЬНОЕ число");
            }
            Console.ReadKey();
        }

        static (int steps, int maxValue) Posled(int value)
        {
            int steps = 1;
            int maxValue = value;
            while (value != 1)
            {
                if (value % 2 == 0)
                {
                    value /= 2;
                }
                else
                {
                    value = 3 * value + 1;
                }
                if (value > maxValue)
                {
                    maxValue = value;
                }
                steps++;
            }
            return (steps, maxValue);
        }
    }
}
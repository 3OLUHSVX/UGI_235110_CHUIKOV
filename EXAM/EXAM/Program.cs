using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите натуральное число: "); if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                (int length, int max) = CollatzSequence(number);
                Console.WriteLine($"Длина последовательности: {length}"); Console.WriteLine($"Максимальное число в последовательности: {max}");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное натуральное число.");
            }
            Console.ReadKey();
        }
        
        static (int length, int max) CollatzSequence(int n)
        {
            int length = 1;
            int max = n;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                if (n > max)
                {
                    max = n;
                }
                length++;
            }
            return (length, max);
        }
    }
}
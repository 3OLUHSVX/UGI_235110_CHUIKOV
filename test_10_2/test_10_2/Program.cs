using System;
using System.Collections.Generic;

namespace test_10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (!TryInputNumber("Введите количество чисел (n):", out n) || n < 2)
            {
                Console.WriteLine("Ошибка: количество чисел должно быть >= 2.");
                Console.ReadKey();
                return;
            }

            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1}-е число: ");
                if (!double.TryParse(Console.ReadLine(), out numbers[i]) || numbers[i] <= 0)
                {
                    Console.WriteLine("Ошибка ввода. Число должно быть положительным.");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("\nСредние геометрические для первых k чисел:");
            for (int k = 2; k <= n; k++)
            {
                double geometricMean = CalculateGeometricMean(numbers, k);
                Console.WriteLine($"k = {k}: {geometricMean:F5}");
            }

            Console.ReadKey();
        }

        static double CalculateGeometricMean(double[] numbers, int k)
        {
            double product = 1.0;
            for (int i = 0; i < k; i++)
            {
                product *= numbers[i];
            }
            return Math.Pow(product, 1.0 / k);
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода.");
                return false;
            }
            return true;
        }
    }
}

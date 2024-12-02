using System;

namespace test_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            if (!TryInputNumber("Введите число n", out n))
            {
                Console.ReadKey();
                return;
            }

            if (n <= 0)
            {
                Console.WriteLine("Условие n - натуральное не выполняется");
                Console.ReadKey();
                return;
            }

            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += (double)(i + 1) / i;
            }

            Console.WriteLine($"Сумма ряда: {sum:F6}");
            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            return true;
        }
    }
}


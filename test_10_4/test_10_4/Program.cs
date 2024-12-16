using System;

namespace test_10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;

            Console.Write("Введите натуральное число: ");
            if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Ошибка ввода. Введите натуральное число.");
                Console.ReadKey();
                return;
            }

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine($"Сумма цифр числа: {sum}");
            Console.ReadKey();
        }
    }
}

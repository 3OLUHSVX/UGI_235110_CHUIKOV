using System;

namespace test_10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int number;

            Console.WriteLine("Введите последовательность чисел (завершите ввод числом 0):");

            while (true)
            {
                Console.Write("Введите число: ");
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                    continue;
                }

                if (number == 0)
                    break;

                sum += number;
                count++;
            }

            Console.WriteLine($"\nКоличество чисел в последовательности: {count}");
            Console.WriteLine($"Сумма чисел последовательности: {sum}");

            Console.ReadKey();
        }
    }
}

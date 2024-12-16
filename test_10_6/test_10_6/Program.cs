using System;
namespace test_10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (!TryInputNumber("Введите натуральное число n:", out n) || n <= 0)
            {
                Console.WriteLine("Ошибка: число должно быть натуральным."); Console.ReadKey();
                return;
            }
            PrintNumberTable(n);
            Console.ReadKey();
        }
        static void PrintNumberTable(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message); var input = Console.ReadLine();
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода."); return false;
            }
            return true;
        }
    }
}
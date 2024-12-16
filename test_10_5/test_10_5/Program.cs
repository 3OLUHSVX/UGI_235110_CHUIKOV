using System;
using System.Collections.Generic;
namespace test_10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            if (!TryInputNumber("Введите ширину прямоугольника (m):", out m) || m <= 0)
            {
                Console.WriteLine("Ошибка: число должно быть натуральным.");
                Console.ReadKey(); return;
            }
            if (!TryInputNumber("Введите высоту прямоугольника (n):", out n) || n <= 0)
            {
                Console.WriteLine("Ошибка: число должно быть натуральным."); Console.ReadKey();
                return;
            }
            Console.WriteLine("\nРазрезаем прямоугольник на квадраты:");
            List<(int size, int count)> squares = CutRectangleIntoSquares(m, n);
            foreach (var square in squares)
            {
                Console.WriteLine($"Размер квадрата: {square.size} x {square.size}, количество: {square.count}");
            }
            Console.WriteLine($"\nОбщее количество квадратов: {GetTotalSquares(squares)}");
            Console.ReadKey();
        }
        static List<(int size, int count)> CutRectangleIntoSquares(int m, int n)
        {
            List<(int size, int count)> result = new List<(int size, int count)>();
            while (m > 0 && n > 0)
            {
                int squareSize = Math.Min(m, n);
                int count = Math.Max(m, n) / squareSize;
                result.Add((squareSize, count));
                if (m > n) m %= n;
                else n %= m;
            }
            return result;
        }
        static int GetTotalSquares(List<(int size, int count)> squares)
        {
            int total = 0;
            foreach (var square in squares)
            {
                total += square.count;
            }
            return total;
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
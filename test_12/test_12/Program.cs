using System;

namespace test_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m от 5 до 20");
            int m;

            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите целое число n");
            int n;
            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (m < 5  || m > 20 || n < 5 || n > 20) {
                Console.WriteLine("Числа не удовлетворяют неравенству 5 <= m,n <= 20");
                Console.ReadKey();
                return;
            }

            var matrix = new int[m, n];
            var rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);

            Console.WriteLine("\nСгенерированная матрица:");
            PrintMatrix(matrix);

            Console.WriteLine("\nВведите число для проверки наличия элементов меньше его:");
            int target;
            if (!TryInputNumber(out target))
            {
                Console.ReadKey();
                return;
            }

            FindElementsLessThan(matrix, target);

            Console.WriteLine("\nРассчитаем произведения нечётных элементов в каждой строке:");
            CalculateOddProducts(matrix);

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            number = n;
            return true;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],3} ");
                Console.WriteLine();
            }
        }

        static void FindElementsLessThan(int[,] matrix, int target)
        {
            bool found = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < target)
                    {
                        Console.WriteLine($"Элемент {matrix[i, j]} меньше {target}, найден в строке {i + 1}, столбце {j}");
                        found = true;
                        return; // Достаточно найти один элемент
                    }
                }
            }

            if (!found)
                Console.WriteLine("Нет элементов меньше заданного числа.");
        }

        static void CalculateOddProducts(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int product = 1;
                bool hasOdd = false;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        product *= matrix[i, j];
                        hasOdd = true;
                    }
                }

                if (hasOdd)
                    Console.WriteLine($"Строка {i+1}: произведение нечётных элементов = {product}");
                else
                    Console.WriteLine($"Строка {i+1}: нет нечётных элементов.");
            }
        }
    }
}
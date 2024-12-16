using System;

namespace test_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива (n): ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода!");
                return;
            }

            int a = -20, b = 20;
            int[] numbers = GenerateRandomArray(n, a, b);
            Console.WriteLine("\nИсходный массив:");
            PrintArray(numbers);

            ChangeSigns(numbers);
            Console.WriteLine("\nМассив с измененными знаками:");
            PrintArray(numbers);

            double sqrtSumSquares = CalculateSqrtSumOfSquares(numbers);
            Console.WriteLine($"\nКвадратный корень суммы квадратов элементов: {sqrtSumSquares:F4}");

            int[] factorialArray = GetFactorialArray(numbers);
            Console.WriteLine("\nМассив факториалов модулей элементов:");
            PrintArray(factorialArray);

            Console.ReadKey();
        }

        static int[] GenerateRandomArray(int size, int min, int max)
        {
            var rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = rnd.Next(min, max + 1);
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (var element in array)
                Console.Write($"{element} ");
            Console.WriteLine();
        }

        static void ChangeSigns(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = -array[i];
        }

        static double CalculateSqrtSumOfSquares(int[] array)
        {
            double sum = 0;
            foreach (var element in array)
                sum += Math.Pow(element, 2);
            return Math.Sqrt(sum);
        }

        static int[] GetFactorialArray(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                result[i] = Factorial(Math.Abs(array[i]));
            return result;
        }

        static int Factorial(int number)
        {
            if (number == 0 || number == 1) return 1;
            int fact = 1;
            for (int i = 2; i <= number; i++)
                fact *= i;
            return fact;
        }
    }
}
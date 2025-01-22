using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        const int limit = 1000;
        bool[] isGenerated = new bool[limit];
        // Помечаем числа, которые были порождены
        for (int i = 1; i < limit; i++)
        {
            int generatedNumber = Generate(i);
            if (generatedNumber < limit)
            {
                isGenerated[generatedNumber] = true;
            }
            Console.ReadKey();
        }
        // Вывод всех самопорождённых чисел
        Console.WriteLine("Самопорождённые числа меньше 1000:");
        for (int i = 1; i < limit; i++)
        {
            if (!isGenerated[i])
            {
                Console.WriteLine(i);
            }
        }
    }
    // Функция для порождения числа
    static int Generate(int number)
    {
        int sum = number; while (number > 0)
        {
            sum += number % 10; // Добавляем последнюю цифру
            number /= 10;       // Убираем последнюю цифру
        }
            return sum;
        }
    }

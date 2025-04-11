using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace bilet6
{
    class Program
    {
        static void Main()
        {
            // Пример целочисленных типов данных
            // byte: 0 до 255 (8 бит)
            byte a = 255;
            Console.WriteLine($"byte: {a}");

            // sbyte: от -128 до 127 (8 бит)
            sbyte b = -128;
            Console.WriteLine($"sbyte: {b}");

            // short: от -32,768 до 32,767 (16 бит)
            short c = 32767;
            Console.WriteLine($"short: {c}");

            // ushort: от 0 до 65,535 (16 бит)
            ushort d = 65535;
            Console.WriteLine($"ushort: {d}");

            // int: от -2,147,483,648 до 2,147,483,647 (32 бит)
            int e = 2147483647;
            Console.WriteLine($"int: {e}");

            // uint: от 0 до 4,294,967,295 (32 бит)
            uint f = 4294967295;
            Console.WriteLine($"uint: {f}");

            // long: от -9,223,372,036,854,775,808 до 9,223,372,036,854,775,807 (64 бит)
            long g = 9223372036854775807;
            Console.WriteLine($"long: {g}");

            // ulong: от 0 до 18,446,744,073,709,551,615 (64 бит)
            ulong h = 18446744073709551615;
            Console.WriteLine($"ulong: {h}");

            Console.WriteLine("\nПример целочисленных арифметических операций:");

            int x = 10;
            int y = 3;

            // Сложение
            int sum = x + y;
            Console.WriteLine($"Сложение: {x} + {y} = {sum}");

            // Вычитание
            int minus = x - y;
            Console.WriteLine($"Вычитание: {x} - {y} = {minus}");

            // Умножение
            int umn = x * y;
            Console.WriteLine($"Умножение: {x} * {y} = {umn}");

            // Деление
            int del = x / y; // Целая часть результата
            Console.WriteLine($"Деление: {x} / {y} = {del}");

            // Остаток от деления
            int ost = x % y;
            Console.WriteLine($"Остаток от деления: {x} % {y} = {ost}");

            Console.ReadKey();
        }
    }
}
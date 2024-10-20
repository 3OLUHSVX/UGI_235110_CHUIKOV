using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_06_2_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "чемпионат";


            var wordFirst = s
                .Remove(0, 3)
                .Remove(1, 1)
                .Remove (3, 2)+
                s
                .Remove(1, 4)
                .Remove(2, 3);

            var wordSecond = s
                .Remove(0, 8) +
                s
                .Remove(0, 1)
                .Remove(3, 5);


            Console.WriteLine("Исходное слово - " + s);
            Console.WriteLine("Первое полученное слово: ");
            Console.WriteLine(wordFirst);
            Console.WriteLine("Второе полученное слово: ");
            Console.WriteLine(wordSecond);

            Console.ReadKey();
        }
    }
    }


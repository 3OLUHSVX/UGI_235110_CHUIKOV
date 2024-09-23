using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01_poem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Не судьба");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ну да, дело не во мне говорит, но ");
            Console.WriteLine("В ком же ещё, ду-ра, как я могу верить, ты же врёшь");
            Console.WriteLine("Всегда, она хочет денег ... ");
            Console.WriteLine( "Не судьба");

            Console.ResetColor();

  
            Console.ReadKey();
        }
    }
}

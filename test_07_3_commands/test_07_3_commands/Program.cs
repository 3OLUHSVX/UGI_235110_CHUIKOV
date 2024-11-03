using System;

namespace Task07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого ферзя");
            var whiteQueenPosition = Console.ReadLine();

            if (!IsPositionCorrect(whiteQueenPosition))
            {
                Console.WriteLine("Некорректная позиция ферзя");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию черного ферзя");
            var blackQueenPosition = Console.ReadLine();

            if (!IsPositionCorrect(blackQueenPosition) || whiteQueenPosition == blackQueenPosition)
            {
                Console.WriteLine("Черный ферзь не должен стоять на той же клетке, что и белый ферзь");
                Console.ReadKey();
                return;
            }

            if (IsQueenStrike(whiteQueenPosition, blackQueenPosition))
            {
                Console.WriteLine("Черный ферзь атакует");
            }
            else
            {
                Console.WriteLine("Черный ферзь не атакует");
                Console.WriteLine("Введите ход белого ферзя");
                var move = Console.ReadLine();

                if (IsQueenMoveValid(whiteQueenPosition, move))
                    Console.WriteLine("Ход разрешен");
                else
                    Console.WriteLine("Ход запрещен");
            }

            Console.ReadKey();
        }

        static bool IsPositionCorrect(string position)
        {
            if (position.Length != 2)
                return false;

            int row;
            int column;
            DecodePosition(position, out column, out row);

            return column >= 1 && column <= 8 && row >= 1 && row <= 8;
        }

        static bool IsQueenStrike(string whiteQueenPosition, string blackQueenPosition)
        {
            int wr, wc, br, bc;
            DecodePosition(whiteQueenPosition, out wc, out wr);
            DecodePosition(blackQueenPosition, out bc, out br);

            // Проверка на атаку: одна горизонталь, вертикаль или диагональ
            return wc == bc || wr == br || Math.Abs(wc - bc) == Math.Abs(wr - br);
        }

        static bool IsQueenMoveValid(string startPosition, string movePosition)
        {
            if (!IsPositionCorrect(movePosition))
                return false;

            int startColumn, startRow, moveColumn, moveRow;
            DecodePosition(startPosition, out startColumn, out startRow);
            DecodePosition(movePosition, out moveColumn, out moveRow);

            return startColumn == moveColumn ||
                   startRow == moveRow ||
                   Math.Abs(startColumn - moveColumn) == Math.Abs(startRow - moveRow);
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            row = int.Parse(position[1].ToString());
            column = (int)position[0] - 0x60;
        }
    }
}
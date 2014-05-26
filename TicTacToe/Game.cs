using System;

namespace TicTacToe {
    public class Game {
        private static string blank = "-";

        private readonly string[,] board;

        public int Size { get; private set; }
        public int Area { get { return Size * Size; } }

        public Player X { get; private set; }
        public Player O { get; private set; }

        public Game(int size) {
            Size = size;

            X = new Player("X");
            O = new Player("O");

            board = new string[Size, Size];
        }

        public void Play() {
            for (var i = 0; i < Size; i++) {
                for (var j = 0; j < Size; j++) {
                    board[i, j] = blank;
                }
            }

            var lastPlayer = X;
            for (var i = 0; i < Area; i++) {
                PlayMove(lastPlayer);
                lastPlayer = lastPlayer == X ? O : X;
            }

            Print();
        }

        private void PlayMove(Player player) {
            Retry:

            var move = player.FindMove(Area);

            while (move > Area - 1) {
                move = player.FindMove(Area);
            }

            var row = move / Size;
            var cell = move - (row * Size);

            if (board[row, cell] != blank) {
                goto Retry;
            }
            board[row, cell] = player.Tile;
        }

        private void Print() {
            for (var i = 0; i < Size; i++) {
                Console.Write("|");
                for (var j = 0; j < Size; j++) {
                    Console.Write(board[i, j]);
                    Console.Write("|");
                }
                Console.WriteLine();
            }
        }
    }
}
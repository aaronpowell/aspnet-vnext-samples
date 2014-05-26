using System;

namespace TicTacToe {
    public class Player {
        public string Tile { get; set; }

        public Player(string tile) {
            Tile = tile;
        }

        public int FindMove(int area) {
            var random = new Random().Next(0, 10000) / 10000d;
            var @base = area / 10d;
            return (int)Math.Floor(random * (@base + 1) * 10d);
        }
    }
}
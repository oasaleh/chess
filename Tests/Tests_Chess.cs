using ChessMVC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Tests
{
    [TestClass]
    public class Tests_Chess
    {
        [TestMethod]
        public void Test_001()
        {
            // Model
            // view
            // Controller

            var moves = new List<string>()
            {
                // White, Black
                "G1F3", "G8F6",
                "C2C4", "G7G6",
                "B1C3", "F8G7",
                "D1D4", "E8G8", // castle
                "C1C4", "D7D5",
                "D1B3", "D5C4", // capture
                "B3C4", // capture, ...
            };

            // The game understands the game/rules and it can apply moves.
            // Chess is Controller.
            var game = new Chess();

            // The board is just squares.
            // Board is Model. It maintains state.
            var board = new Board();

            var printer = new BoardPrinter();

            // These are events.
            //board.Move += (move) => Debug.WriteLine("");
            //game.Result += (result) => Debug.WriteLine("");
            //game.Capture += (capture) => Debug.WriteLine("");

            foreach (var move in moves)
            {
                game.Apply(move, board);

                printer.Show(board);
            }
        }

        private class BoardPrinter
        {
            internal void Show(Board board)
            {
                for (int c = 1; c <= 8; c++)
                {
                    for (int r = 1; r <= 8; r++)
                    {
                        Debug.Write($"[{board[c, r]?.ToString() ?? " "}]");
                    }
                    Debug.WriteLine(string.Empty);
                }
                Debug.WriteLine(string.Empty.PadRight(8 * 3, '-'));
            }
        }
    }
}
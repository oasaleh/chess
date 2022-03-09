using ChessMVC;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            var moves = new List<Strings>();

            // The game understands the game/rules and it can apply moves.
            var game = new Chess();

            // The board is just squares.
            var board = new Board();

            var printer = new BoardPrinter();

            board.Move += (move) => Debug.WriteLine("");
            game.Result += (result) => Debug.WriteLine("");
            game.Capture += (capture) => Debug.WriteLine("");

            foreach (var move in moves)
            {
                game.Apply(move, board);

                printer.show(board);
            }
        }

        private class BoardPrinter
        {
        }
    }
}
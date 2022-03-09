using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

            foreach (var move in moves)
            {
                game.Apply(move, board);

                printer.show(board);
            }
        }
    }
}
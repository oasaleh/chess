using Microsoft.VisualBasic;

namespace ChessMVC
{
    public class Chess
    {
        public void Apply(string move, Board board)
        {
            var start = move.Substring(0, 2);
            var dest = move.Substring(2, 2);

            // 65 and 48 are to convert characters to board coordinates.
            board[dest[0] - 65, dest[1] - 48] = board[start[0] - 65, start[1] - 48];
            board[start[0] - 65, start[1] - 48] = null;
        }
    }
}
namespace ChessMVC
{
    public class Board
    {
        private ChessPiece[,] board = new ChessPiece[8, 8];
        public ChessPiece this[int col, int row]
        {
            get
            {
                // The board itself will translate the numbers for us.
                return board[col-1, row-1];
            }
            set
            {
                board[col - 1, row - 1] = value;
            }
        }
    }
}
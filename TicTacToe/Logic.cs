namespace TicTacToe;

public class Logic
{
    public static char[,] CreateEmptyBoard()
    {
        var board = new char[Constants.BoardSize, Constants.BoardSize];
        for (int i = 0; i < Constants.BoardSize; i++)
        {
            for (int j = 0; j < Constants.BoardSize; j++)
            {
                board[i, j] = Constants.EmptyCell;
            }
        }
        return board;
    }

    
    public static void PlayerTurn(char[,] board, char playerSymbol)
    {
        while (true)
        {
            var (row, col) = UI.AskMove();

            if (board[row, col] == Constants.EmptyCell)
            {
                board[row, col] = playerSymbol;
                break;
            }
            else
            {
                Console.WriteLine("This cell is already being used. Please choose another cell.");
            }
        }
    }
}
namespace TicTacToe;

public class Logic
{
    public static char[,] CreateEmptyBoard()
    {
        var board = new char[Constants.BOARD_SIZE, Constants.BOARD_SIZE];
        for (int i = 0; i < Constants.BOARD_SIZE; i++)
        {
            for (int j = 0; j < Constants.BOARD_SIZE; j++)
            {
                board[i, j] = Constants.EMPTY_CELL;
            }
        }
        return board;
    }

    
    public static void PlayerTurn(char[,] board, char playerSymbol)
    {
        while (true)
        {
            var (row, col) = UI.AskMove();

            if (board[row, col] == Constants.EMPTY_CELL)
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
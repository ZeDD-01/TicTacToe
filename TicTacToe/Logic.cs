namespace TicTacToe;

public class Logic
{
    public static char[,] CreateEmptyBoard()
    {
        return new char[,]
        {
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' }
        };
    }
    
    public static void PlayerTurn(char[,] board, char playerSymbol)
    {
        while (true)
        {
            var (row, col) = UI.AskMove();

            if (board[row, col] == ' ')
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
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
}
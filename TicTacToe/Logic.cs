using System.Collections.Generic;

namespace TicTacToe;

public class Logic
{
    static Random random = new Random();
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

    public static bool TryMakeMove(char[,] board, int row, int col, char playerSymbol)
    {
        if (board[row, col] == Constants.EMPTY_CELL)
        {
            board[row, col] = playerSymbol;
            return true;
        }
        return false;
    }
    
    public static void MakeRandomAIMove(char[,] board, char aiSymbol)
    {
        var availableMoves = new List<(int row, int col)>();

        for (int i = 0; i < Constants.BOARD_SIZE; i++)
        {
            for (int j = 0; j < Constants.BOARD_SIZE; j++)
            {
                if (board[i, j] == Constants.EMPTY_CELL)
                {
                    availableMoves.Add((i, j));
                }
            }
        }

        if (availableMoves.Count > 0)
        {
            var move = availableMoves[random.Next(availableMoves.Count)];
            board[move.row, move.col] = aiSymbol;
            Console.WriteLine($"AI chooses position: {move.row} {move.col}");
        }
    }
}
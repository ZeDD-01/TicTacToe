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

    public static bool isBoardFull(char[,] board)
    {
        for (int i = 0; i < Constants.BOARD_SIZE; i++)
        {
            for (int j = 0; j < Constants.BOARD_SIZE; j++)
            {
                if (board[i, j] == Constants.EMPTY_CELL)
                    return false;
            }
        }

        return true;
    }

    public static char CheckWinner(char[,] board)
    {
        for (int i = 0; i < Constants.BOARD_SIZE; i++)
        {
            if (board[i, 0] != Constants.EMPTY_CELL &&
                board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                return board[i, 0];
            }
        }

        for (int j = 0; j < Constants.BOARD_SIZE; j++)
        {
            if (board[0, j] != Constants.EMPTY_CELL &&
                board[0, j] == board[1, j] && board[1, j] == board[2, j])
            {
                return board[0, j];
            }
        }

        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            return board[0, 0];
        }

        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            return board[0, 2];
        }
        
        return Constants.EMPTY_CELL;
    }


}
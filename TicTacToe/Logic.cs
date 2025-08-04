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

        // Rows
        for (int i = 0; i < Constants.BOARD_SIZE; i++)
        {
            char first = board[i, 0];
            if (first == Constants.EMPTY_CELL) continue;

            bool win = true;
            for (int j = 1; j < Constants.BOARD_SIZE; j++)
            {
                if (board[i, j] != first)
                {
                    win = false;
                    break;
                }
            }
            if (win) return first;
        }

        // Columns
        for (int j = 0; j < Constants.BOARD_SIZE; j++)
        {
            char first = board[0, j];
            if (first == Constants.EMPTY_CELL) continue;

            bool win = true;
            for (int i = 1; i < Constants.BOARD_SIZE; i++)
            {
                if (board[i, j] != first)
                {
                    win = false;
                    break;
                }
            }
            if (win) return first;
        }

        // diagonale
        char diag1 = board[0, 0];
        if (diag1 != Constants.EMPTY_CELL)
        {
            bool win = true;
            for (int i = 1; i < Constants.BOARD_SIZE; i++)
            {
                if (board[i, i] != diag1)
                {
                    win = false;
                    break;
                }
            }
            if (win) return diag1;
        }

        // reverse diagonale
        char diag2 = board[0, Constants.BOARD_SIZE - 1];
        if (diag2 != Constants.EMPTY_CELL)
        {
            bool win = true;
            for (int i = 1; i < Constants.BOARD_SIZE; i++)
            {
                if (board[i, Constants.BOARD_SIZE - 1 - i] != diag2)
                {
                    win = false;
                    break;
                }
            }
            if (win) return diag2;
        }

        // Tie
        return Constants.EMPTY_CELL;
    }


}
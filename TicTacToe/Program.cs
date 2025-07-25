using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.PrintWelcome();

            char playerSymbol = UI.ChooseSymbol();
            char aiSymbol = (playerSymbol == Constants.SYMBOL_X) ? Constants.SYMBOL_O : Constants.SYMBOL_X;

            char[,] board = Logic.CreateEmptyBoard();

            UI.PrintBoard(board);

            Console.WriteLine($"You play as {playerSymbol}, the AI will be {aiSymbol}.");

            while (true)
            {

                while (true)
                {
                    var (row, col) = UI.AskMove();

                    if (Logic.TryMakeMove(board, row, col, playerSymbol))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This cell is already being used. Please choose another cell.");
                    }
                }

                UI.PrintBoard(board);

                if (Logic.isBoardFull(board))
                {
                    break;
                }

                Logic.MakeRandomAIMove(board, aiSymbol);

                UI.PrintBoard(board);
            }
            Console.WriteLine("Board is filled");
        }
    }
}
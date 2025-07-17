using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.PrintWelcome();

            char playerSymbol = UI.ChooseSymbol();
            char aiSymbol = (playerSymbol == 'X') ? 'O' : 'X';

            char[,] board = Logic.CreateEmptyBoard();

            UI.PrintBoard(board);

            Console.WriteLine($"You play as {playerSymbol}, the AI will be {aiSymbol}.");
            
            Logic.PlayerTurn(board, playerSymbol);
            
            UI.PrintBoard(board);
        }
    }
}
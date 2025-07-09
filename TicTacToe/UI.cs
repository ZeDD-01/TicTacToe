namespace TicTacToe;

public class UI
{
    public static void PrintWelcome()
    {
        Console.WriteLine("Welcome to Oh Noe - Tic Tac Toe!");
    }

    public static char ChooseSymbol()
    {
        Console.WriteLine("Would you like to play as X (X) or as Circle (O)?");
        while (true)
        {
            string input = Console.ReadLine().ToUpper();
            if (input == "X" || input == "O")
            {
                return input[0];
            }
            Console.WriteLine("Invalid Input. Please choose X or O .");
        }
    }

    public static void PrintBoard(char[,] board)
    {
        Console.WriteLine("Current boarf:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" {board[i,0]} | {board[i,1]} | {board[i,2]} ");
            if (i < 2) Console.WriteLine("---|---|---");
        }
    }
}
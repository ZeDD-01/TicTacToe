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
    
    public static (int row, int col) AskMove()
    {
        while (true)
        {
            Console.Write("Please choose the position in the grid (e.g. 0 2 for Row 0, Column 2): ");
            string input = Console.ReadLine();
            var parts = input.Split(' ');
            if (parts.Length == 2 &&
                int.TryParse(parts[0], out int row) &&
                int.TryParse(parts[1], out int col) &&
                row >= 0 && row < 3 &&
                col >= 0 && col < 3)
            {
                return (row, col);
            }
            Console.WriteLine("Invalid Input. Please enter two numbers between 0 and 2, separated by space.");
        }
    }
}
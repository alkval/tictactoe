using System.Data.Common;

Console.WriteLine("Welcome to Tic Tac Toe!");

Console.WriteLine("Player1 ( X ) vs Player2 ( O )");

ConsoleKeyInfo key;
int option = 0; 
(int left, int top) = Console.GetCursorPosition();
int turn = 0;
int winner = 0;
string marker = "_";

int [] options = [0, 0, 0, 
                  0, 0, 0, 
                  0, 0, 0];

while (winner == 0)
{

    Console.SetCursorPosition(left, top);

    if (turn % 2 == 0)
    {
        Console.WriteLine("\nPlayer1's turn: X\n");
    }
    else
    {
        Console.WriteLine("\nPlayer2's turn: O\n");
    }
    
    Console.WriteLine($" {(option == 0 ? marker + " |" :"  |")} {(option == 1 ? marker + " |" :"  |")} {(option == 2 ? marker:"")}"); 
    Console.WriteLine($"---|---|---");
    Console.WriteLine($" {(option == 3 ? marker + " |" :"  |")} {(option == 4 ? marker + " |" :"  |")} {(option == 5 ? marker:"")}"); 
    Console.WriteLine($"---|---|---");
    Console.WriteLine($" {(option == 6 ? marker + " |" :"  |")} {(option == 7 ? marker + " |" :"  |")} {(option == 8 ? marker:"")}"); 

    key = Console.ReadKey(true);

    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            if (option > 2 && option < 9)
            {
                option -= 3;
            }
            break;
        case ConsoleKey.DownArrow:
            if (option < 6 && option >= 0)
            {
                option += 3;
            }
            break;
        case ConsoleKey.LeftArrow:
            if (option % 3 != 0)
            {
                option--;
            }
            break;
        case ConsoleKey.RightArrow:
            if ((option + 1) % 3 != 0)
            {
                option++;
            }
            break;
        case ConsoleKey.Enter:
            if (options[option] == 0)
            {
                options[option] = turn % 2 == 0 ? 1 : 2;
                turn += 1;
            }
            break;
    }
    if (options[0] == options[1] && options[1] == options[2] && options[0] != 0)
    {
        winner = options[0];
        break;
    }
    if (options[3] == options[4] && options[4] == options[5] && options[3] != 0)
    {
        winner = options[3];
        break;
    }
    if (options[6] == options[7] && options[7] == options[8] && options[6] != 0)
    {
        winner = options[6];
        break;
    }
    if (options[0] == options[3] && options[3] == options[6] && options[0] != 0)
    {
        winner = options[0];
        break;
    }
    if (options[1] == options[4] && options[4] == options[7] && options[1] != 0)
    {
        winner = options[1];
        break;
    }
    if (options[2] == options[5] && options[5] == options[8] && options[2] != 0)
    {
        winner = options[2];
        break;
    }
    if (options[0] == options[4] && options[4] == options[8] && options[0] != 0)
    {
        winner = options[0];
        break;
    }
    if (options[2] == options[4] && options[4] == options[6] && options[2] != 0)
    {
        winner = options[2];
        break;
    }
    if (options[0] != 0 && options[1] != 0 && options[2] != 0 && options[3] != 0 && options[4] != 0 && options[5] != 0 && options[6] != 0 && options[7] != 0 && options[8] != 0)
    {
        break;
    }

}
Console.WriteLine($"Player {winner} wins!");

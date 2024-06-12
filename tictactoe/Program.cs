using System.Data.Common;

Console.WriteLine("Welcome to Tic Tac Toe!");

Console.WriteLine("Player1 ( X ) vs Player2 ( O )");

ConsoleKeyInfo key;
int option = 0; 
(int left, int top) = Console.GetCursorPosition();
int turn = 0;
int winner = 0;
string marker = "_";
string markerx = "X";
string markero = "O";
string markerb = " ";

int [] options = [0, 0, 0, 
                  0, 0, 0, 
                  0, 0, 0];

while (winner == 0)
{
    Console.Clear();
    Console.SetCursorPosition(left, top);

    if (turn % 2 == 0)
    {
        Console.WriteLine("\nPlayer1's turn: X\n");
    }
    else
    {
        Console.WriteLine("\nPlayer2's turn: O\n");
    }
    //TODO : Make the WriteLines it into a function to make the code cleaner and more readable
    Console.WriteLine($" {(options[0] == 1 ? markerx + " |": options[0] == 2 ? markero +" |": options[0] == 0 ? markerb +" |" : "")} {(options[1] == 1 ? markerx + " |": options[1] == 2 ? markero +" |": options[1] == 0 ? markerb +" |" : "")} {(options[2] == 1 ? markerx : options[2] == 2 ? markero : options[2] == 0 ? markerb : "")}"); 
    Console.WriteLine($"-{(option == 0 ? marker : "-")}-|-{(option == 1 ? marker : "-")}-|-{(option == 2 ? marker : "-")}-");
    Console.WriteLine($" {(options[3] == 1 ? markerx + " |": options[3] == 2 ? markero +" |": options[3] == 0 ? markerb +" |" : "")} {(options[4] == 1 ? markerx + " |": options[4] == 2 ? markero +" |": options[4] == 0 ? markerb +" |" : "")} {(options[5] == 1 ? markerx : options[5] == 2 ? markero : options[5] == 0 ? markerb : "")}"); 
    Console.WriteLine($"-{(option == 3 ? marker : "-")}-|-{(option == 4 ? marker : "-")}-|-{(option == 5 ? marker : "-")}-");
    Console.WriteLine($" {(options[6] == 1 ? markerx + " |": options[6] == 2 ? markero +" |": options[6] == 0 ? markerb +" |" : "")} {(options[7] == 1 ? markerx + " |": options[7] == 2 ? markero +" |": options[7] == 0 ? markerb +" |" : "")} {(options[8] == 1 ? markerx : options[8] == 2 ? markero : options[8] == 0 ? markerb : "")}"); 
    Console.WriteLine($" {(option == 6 ? marker : " ")}   {(option == 7 ? marker : " ")}   {(option == 8 ? marker : " ")} ");
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
        Console.Clear();
        winner = options[0];
        Console.WriteLine($" {(options[0] == 1 ? markerx + " |": options[0] == 2 ? markero +" |": options[0] == 0 ? markerb +" |" : "")} {(options[1] == 1 ? markerx + " |": options[1] == 2 ? markero +" |": options[1] == 0 ? markerb +" |" : "")} {(options[2] == 1 ? markerx : options[2] == 2 ? markero : options[2] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[3] == 1 ? markerx + " |": options[3] == 2 ? markero +" |": options[3] == 0 ? markerb +" |" : "")} {(options[4] == 1 ? markerx + " |": options[4] == 2 ? markero +" |": options[4] == 0 ? markerb +" |" : "")} {(options[5] == 1 ? markerx : options[5] == 2 ? markero : options[5] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[6] == 1 ? markerx + " |": options[6] == 2 ? markero +" |": options[6] == 0 ? markerb +" |" : "")} {(options[7] == 1 ? markerx + " |": options[7] == 2 ? markero +" |": options[7] == 0 ? markerb +" |" : "")} {(options[8] == 1 ? markerx : options[8] == 2 ? markero : options[8] == 0 ? markerb : "")}"); 
        
        break;
    }
    if (options[3] == options[4] && options[4] == options[5] && options[3] != 0)
    {
        Console.Clear();
        winner = options[3];
        Console.WriteLine($" {(options[0] == 1 ? markerx + " |": options[0] == 2 ? markero +" |": options[0] == 0 ? markerb +" |" : "")} {(options[1] == 1 ? markerx + " |": options[1] == 2 ? markero +" |": options[1] == 0 ? markerb +" |" : "")} {(options[2] == 1 ? markerx : options[2] == 2 ? markero : options[2] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[3] == 1 ? markerx + " |": options[3] == 2 ? markero +" |": options[3] == 0 ? markerb +" |" : "")} {(options[4] == 1 ? markerx + " |": options[4] == 2 ? markero +" |": options[4] == 0 ? markerb +" |" : "")} {(options[5] == 1 ? markerx : options[5] == 2 ? markero : options[5] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[6] == 1 ? markerx + " |": options[6] == 2 ? markero +" |": options[6] == 0 ? markerb +" |" : "")} {(options[7] == 1 ? markerx + " |": options[7] == 2 ? markero +" |": options[7] == 0 ? markerb +" |" : "")} {(options[8] == 1 ? markerx : options[8] == 2 ? markero : options[8] == 0 ? markerb : "")}"); 
        break;
    }
    if (options[6] == options[7] && options[7] == options[8] && options[6] != 0)
    {
        Console.Clear();
        winner = options[6];
        Console.WriteLine($" {(options[0] == 1 ? markerx + " |": options[0] == 2 ? markero +" |": options[0] == 0 ? markerb +" |" : "")} {(options[1] == 1 ? markerx + " |": options[1] == 2 ? markero +" |": options[1] == 0 ? markerb +" |" : "")} {(options[2] == 1 ? markerx : options[2] == 2 ? markero : options[2] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[3] == 1 ? markerx + " |": options[3] == 2 ? markero +" |": options[3] == 0 ? markerb +" |" : "")} {(options[4] == 1 ? markerx + " |": options[4] == 2 ? markero +" |": options[4] == 0 ? markerb +" |" : "")} {(options[5] == 1 ? markerx : options[5] == 2 ? markero : options[5] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[6] == 1 ? markerx + " |": options[6] == 2 ? markero +" |": options[6] == 0 ? markerb +" |" : "")} {(options[7] == 1 ? markerx + " |": options[7] == 2 ? markero +" |": options[7] == 0 ? markerb +" |" : "")} {(options[8] == 1 ? markerx : options[8] == 2 ? markero : options[8] == 0 ? markerb : "")}"); 
        break;
    }
    if (options[0] == options[3] && options[3] == options[6] && options[0] != 0)
    {
        Console.Clear();
        winner = options[0];
        Console.WriteLine($" {(options[0] == 1 ? markerx + " |": options[0] == 2 ? markero +" |": options[0] == 0 ? markerb +" |" : "")} {(options[1] == 1 ? markerx + " |": options[1] == 2 ? markero +" |": options[1] == 0 ? markerb +" |" : "")} {(options[2] == 1 ? markerx : options[2] == 2 ? markero : options[2] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[3] == 1 ? markerx + " |": options[3] == 2 ? markero +" |": options[3] == 0 ? markerb +" |" : "")} {(options[4] == 1 ? markerx + " |": options[4] == 2 ? markero +" |": options[4] == 0 ? markerb +" |" : "")} {(options[5] == 1 ? markerx : options[5] == 2 ? markero : options[5] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[6] == 1 ? markerx + " |": options[6] == 2 ? markero +" |": options[6] == 0 ? markerb +" |" : "")} {(options[7] == 1 ? markerx + " |": options[7] == 2 ? markero +" |": options[7] == 0 ? markerb +" |" : "")} {(options[8] == 1 ? markerx : options[8] == 2 ? markero : options[8] == 0 ? markerb : "")}"); 
        break;
    }
    if (options[1] == options[4] && options[4] == options[7] && options[1] != 0)
    {
        Console.Clear();
        winner = options[1];
        Console.WriteLine($" {(options[0] == 1 ? markerx + " |": options[0] == 2 ? markero +" |": options[0] == 0 ? markerb +" |" : "")} {(options[1] == 1 ? markerx + " |": options[1] == 2 ? markero +" |": options[1] == 0 ? markerb +" |" : "")} {(options[2] == 1 ? markerx : options[2] == 2 ? markero : options[2] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[3] == 1 ? markerx + " |": options[3] == 2 ? markero +" |": options[3] == 0 ? markerb +" |" : "")} {(options[4] == 1 ? markerx + " |": options[4] == 2 ? markero +" |": options[4] == 0 ? markerb +" |" : "")} {(options[5] == 1 ? markerx : options[5] == 2 ? markero : options[5] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[6] == 1 ? markerx + " |": options[6] == 2 ? markero +" |": options[6] == 0 ? markerb +" |" : "")} {(options[7] == 1 ? markerx + " |": options[7] == 2 ? markero +" |": options[7] == 0 ? markerb +" |" : "")} {(options[8] == 1 ? markerx : options[8] == 2 ? markero : options[8] == 0 ? markerb : "")}"); 
        break;
    }
    if (options[2] == options[5] && options[5] == options[8] && options[2] != 0)
    {
        Console.Clear();
        winner = options[2];
        Console.WriteLine($" {(options[0] == 1 ? markerx + " |": options[0] == 2 ? markero +" |": options[0] == 0 ? markerb +" |" : "")} {(options[1] == 1 ? markerx + " |": options[1] == 2 ? markero +" |": options[1] == 0 ? markerb +" |" : "")} {(options[2] == 1 ? markerx : options[2] == 2 ? markero : options[2] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[3] == 1 ? markerx + " |": options[3] == 2 ? markero +" |": options[3] == 0 ? markerb +" |" : "")} {(options[4] == 1 ? markerx + " |": options[4] == 2 ? markero +" |": options[4] == 0 ? markerb +" |" : "")} {(options[5] == 1 ? markerx : options[5] == 2 ? markero : options[5] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[6] == 1 ? markerx + " |": options[6] == 2 ? markero +" |": options[6] == 0 ? markerb +" |" : "")} {(options[7] == 1 ? markerx + " |": options[7] == 2 ? markero +" |": options[7] == 0 ? markerb +" |" : "")} {(options[8] == 1 ? markerx : options[8] == 2 ? markero : options[8] == 0 ? markerb : "")}"); 
        break;
    }
    if (options[0] == options[4] && options[4] == options[8] && options[0] != 0)
    {
        Console.Clear();
        winner = options[0];
        Console.WriteLine($" {(options[0] == 1 ? markerx + " |": options[0] == 2 ? markero +" |": options[0] == 0 ? markerb +" |" : "")} {(options[1] == 1 ? markerx + " |": options[1] == 2 ? markero +" |": options[1] == 0 ? markerb +" |" : "")} {(options[2] == 1 ? markerx : options[2] == 2 ? markero : options[2] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[3] == 1 ? markerx + " |": options[3] == 2 ? markero +" |": options[3] == 0 ? markerb +" |" : "")} {(options[4] == 1 ? markerx + " |": options[4] == 2 ? markero +" |": options[4] == 0 ? markerb +" |" : "")} {(options[5] == 1 ? markerx : options[5] == 2 ? markero : options[5] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[6] == 1 ? markerx + " |": options[6] == 2 ? markero +" |": options[6] == 0 ? markerb +" |" : "")} {(options[7] == 1 ? markerx + " |": options[7] == 2 ? markero +" |": options[7] == 0 ? markerb +" |" : "")} {(options[8] == 1 ? markerx : options[8] == 2 ? markero : options[8] == 0 ? markerb : "")}"); 
        break;
    }
    if (options[2] == options[4] && options[4] == options[6] && options[2] != 0)
    {
        Console.Clear();
        winner = options[2];
        Console.WriteLine($" {(options[0] == 1 ? markerx + " |": options[0] == 2 ? markero +" |": options[0] == 0 ? markerb +" |" : "")} {(options[1] == 1 ? markerx + " |": options[1] == 2 ? markero +" |": options[1] == 0 ? markerb +" |" : "")} {(options[2] == 1 ? markerx : options[2] == 2 ? markero : options[2] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[3] == 1 ? markerx + " |": options[3] == 2 ? markero +" |": options[3] == 0 ? markerb +" |" : "")} {(options[4] == 1 ? markerx + " |": options[4] == 2 ? markero +" |": options[4] == 0 ? markerb +" |" : "")} {(options[5] == 1 ? markerx : options[5] == 2 ? markero : options[5] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[6] == 1 ? markerx + " |": options[6] == 2 ? markero +" |": options[6] == 0 ? markerb +" |" : "")} {(options[7] == 1 ? markerx + " |": options[7] == 2 ? markero +" |": options[7] == 0 ? markerb +" |" : "")} {(options[8] == 1 ? markerx : options[8] == 2 ? markero : options[8] == 0 ? markerb : "")}"); 
        break;
    }
    if (options[0] != 0 && options[1] != 0 && options[2] != 0 && options[3] != 0 && options[4] != 0 && options[5] != 0 && options[6] != 0 && options[7] != 0 && options[8] != 0)
    {
        Console.Clear();
        Console.WriteLine($" {(options[0] == 1 ? markerx + " |": options[0] == 2 ? markero +" |": options[0] == 0 ? markerb +" |" : "")} {(options[1] == 1 ? markerx + " |": options[1] == 2 ? markero +" |": options[1] == 0 ? markerb +" |" : "")} {(options[2] == 1 ? markerx : options[2] == 2 ? markero : options[2] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[3] == 1 ? markerx + " |": options[3] == 2 ? markero +" |": options[3] == 0 ? markerb +" |" : "")} {(options[4] == 1 ? markerx + " |": options[4] == 2 ? markero +" |": options[4] == 0 ? markerb +" |" : "")} {(options[5] == 1 ? markerx : options[5] == 2 ? markero : options[5] == 0 ? markerb : "")}"); 
        Console.WriteLine($"---|---|---");
        Console.WriteLine($" {(options[6] == 1 ? markerx + " |": options[6] == 2 ? markero +" |": options[6] == 0 ? markerb +" |" : "")} {(options[7] == 1 ? markerx + " |": options[7] == 2 ? markero +" |": options[7] == 0 ? markerb +" |" : "")} {(options[8] == 1 ? markerx : options[8] == 2 ? markero : options[8] == 0 ? markerb : "")}"); 
        break;
    }

}
if (winner != 0)
    Console.WriteLine($"Player {winner} wins!");
else
    Console.WriteLine("It's a tie!");
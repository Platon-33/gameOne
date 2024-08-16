//C#, basic stuff I got from ChatGPT. I understand how everything function, just not sure how to optimize
//Right now, all I have is a character class that can move up down left righ and return a int.
using System;

public class Player
{
    // Fields to track the player's position
    private int x;
    private int y;

    // Constructor to initialize the player's position
    public Player(int startX, int startY)
    {
        x = startX;
        y = startY;
    }

    // Methods to move the player along the basic axis
    public void MoveForward()
    {
        x += 1;  // 
        Console.WriteLine($"Player moved to position: ({x}, {y})");
    }

    public void MoveBack()
    {
        x -= 1;  
        Console.WriteLine($"Player moved to position: ({x}, {y})");
    }

    public void MoveLeft()
    {
        y -= 1;  
        Console.WriteLine($"Player moved to position: ({x}, {y})");
    }

    public void MoveRight()
    {
        y += 1;  
        Console.WriteLine($"Player moved to position: ({x}, {y})");
    }


    // Method to start listening for key presses
    public void Start()
    {
        Console.WriteLine("Use 'WASD' to move the player. Press 'ESC' to quit.");
        while (true)
        {
            // Wait for a key press
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
          
            if (keyInfo.Key == ConsoleKey.W)
            {
                MoveForward();
            }

            if (keyInfo.Key == ConsoleKey.S)
            {
              MoveBack();
            }

            if (keyInfo.Key == ConsoleKey.A)
            {
              MoveLeft();
            }

            if (keyInfo.Key == ConsoleKey.D)
            {
              MoveRight();
            }
            // Check if the 'ESC' key was pressed to quit
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Quitting...");
                break;
            }
        }
    }

    // Entry point of the program
    public static void Main(string[] args)
    {
        // Create a new player at position (0, 0)
        Player player = new Player(0, 0);

        // Start the key listening loop
        player.Start();
    }
}

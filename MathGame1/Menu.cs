namespace MathGame1;

internal class Menu
{
    GameEngine gameEngine = new();
    internal void ShowMenu(string name, DateTime date)
    {
        Console.WriteLine($"Hello {name.ToUpper()}, welcome to the Math game. Today is {date.DayOfWeek}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
        Console.WriteLine("\n");
        var isGameOn = true;

        do
        {
            Console.Clear();
            
            Console.WriteLine(@$"Please choose which game you would like to play:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
            Console.WriteLine("----------------------------------------------------");

            var gameSelected = Console.ReadLine();

            switch (gameSelected.Trim().ToLower())
            {
                case "v":
                    Helpers.GetHistory();
                    break;
                case "a":
                    gameEngine.AdditionGame("Addition game");
                    break;
                case "s":
                    gameEngine.SubtractionGame("Subtraction game");
                    break;
                case "m":
                    gameEngine.MultiplicationGame("Multiplication game");
                    break;
                case "d":
                    gameEngine.DivisionGame("Division game");
                    break;
                case "q":
                    Console.WriteLine("Goodbye");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Environment.Exit(1);
                    break;
            }
        } while (isGameOn);
    }
}


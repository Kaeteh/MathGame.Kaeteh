using System.Timers;
using MathGame1.Models;
using Timer = System.Timers.Timer;

namespace MathGame1;

internal class Helpers
{
    internal static List<Game> games = new List<Game>
    {
        // new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        // new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        // new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        // new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        // new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        // new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        // new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        // new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        // new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        // new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        // new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        // new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        // new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
    };
    
    internal static void AddToHistory(int gameScore, GameType gameType)
    {
        games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType
        });
    }
    internal static void GetHistory()
    {
        var gamesToPrint = games.Where(x => x.Date > new DateTime(2022, 08, 09)).OrderByDescending(x => x.Score);
        
        Console.Clear();
        Console.WriteLine("Games History:");
        Console.WriteLine("--------------------------\n");
        foreach (var game in gamesToPrint)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
        }
        Console.WriteLine("--------------------------\n");
        Console.WriteLine("Press any key to continue back to the main menu\n");
        Console.ReadLine();
    }

    internal static int[] GetDivisionNumbers(string diffSelect)
    {
        var random = new Random();
        var firstNumber = random.Next(0, 99);
        var secondNumber = random.Next(0, 99);
        var result = new int[2];
        Console.Clear();

        while (firstNumber % secondNumber != 0)
        {
            if (diffSelect == "1")
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
            }
            else if (diffSelect == "2")
            {
                firstNumber = random.Next(1, 200);
                secondNumber = random.Next(1, 200);
            }
            else if (diffSelect == "3")
            {  
                firstNumber = random.Next(100, 600);
                secondNumber = random.Next(100, 600);
            }
        }
    
        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }

    internal static string? ValidateResults(string result)
    {
        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an interger (number), try again..");
            result = Console.ReadLine();
        }

        return result;
    }

    internal static string? GetDifficulty(string diffSelect)
    {
        
        while (string.IsNullOrEmpty(diffSelect) || !Int32.TryParse(diffSelect, out int num) || num < 1 || num > 3)
        {
            Console.WriteLine(@$"It must be a number between 1 and 3");
            diffSelect = Console.ReadLine();
        }
        
        return diffSelect;
    }

    internal static string GetName()
    {
        Console.WriteLine("Please enter your name: ");
        var name = Console.ReadLine();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name cannot be empty!");
            name = Console.ReadLine();
        }
        return name;
    }
    
    internal static Timer timer;
    internal static DateTime startTime;

    internal static void StartTimer()
    {
        startTime = DateTime.Now;
        timer = new Timer(1000)
        {
            AutoReset = true
        };
        timer.Start();
    }

    internal static void StopTimer()
    {
        timer.Stop();
        
        var elapsedTime = DateTime.Now - startTime;
        
        var minutes = elapsedTime.Minutes;
        var seconds = elapsedTime.Seconds;
        
        Console.WriteLine($"\nGame ended at: {DateTime.Now:HH:mm:ss dd/MM/yyyy}");
        Console.WriteLine($"Total game time: {minutes:D2}:{seconds:D2} (MM:SS)");
    }
}
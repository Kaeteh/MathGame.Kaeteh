using MathGame1.Models;

namespace MathGame1;

internal class GameEngine
{ 
    internal void AdditionGame(string message)
    {
    Console.Clear();
    Console.WriteLine(message);
    
    var random = new Random();
    var score = 0;
    
    Console.WriteLine(@$"Please choose which difficulty you would like:
1 - Easy
2 - Normal
3 - Hard");
    var diffSelect = Console.ReadLine();
    diffSelect = Helpers.GetDifficulty(diffSelect);
    Helpers.StartTimer();
    for (int i = 0; i < 5; i++)
    {
        
        int firstNumber = 0;
        int secondNumber = 0;

        Console.Clear();
        Console.Write(message);
        if (diffSelect == "1")
        {
            Console.WriteLine(" - Easy difficulty");
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
        }
        else if (diffSelect == "2")
        {
            Console.WriteLine(" - Normal difficulty");
            firstNumber = random.Next(1, 200);
            secondNumber = random.Next(1, 200);
        }
        else if (diffSelect == "3")
        {  
            Console.WriteLine(" - Hard difficulty");
            firstNumber = random.Next(100, 600);
            secondNumber = random.Next(100, 600);

        }
        else
        {
            
            Console.WriteLine(" Please select difficulty");
        }
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        
        var result = Console.ReadLine();

        result = Helpers.ValidateResults(result);
        
        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect :(. Press any key for the next question");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score} Press any key to return to the menu..");
            Helpers.StopTimer();
            Console.ReadLine();
        }
    }

    Helpers.AddToHistory(score, GameType.Addition);
}
internal void SubtractionGame(string message)
{
    var random = new Random();
    var score = 0;
    
    Console.Clear();
    Console.WriteLine(@$"Please choose which difficulty you would like:
1 - Easy
2 - Normal
3 - Hard");
    var diffSelect = Console.ReadLine();
    diffSelect = Helpers.GetDifficulty(diffSelect);
    Helpers.StartTimer();
    for (int i = 0; i < 5; i++)
    {
        
        int firstNumber = 0;
        int secondNumber = 0;

        Console.Clear();
        Console.Write(message);
        if (diffSelect == "1")
        {
            Console.WriteLine(" - Easy difficulty");
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
        }
        else if (diffSelect == "2")
        {
            Console.WriteLine(" - Normal difficulty");
            firstNumber = random.Next(1, 200);
            secondNumber = random.Next(1, 200);
        }
        else if (diffSelect == "3")
        {  
            Console.WriteLine(" - Hard difficulty");
            firstNumber = random.Next(100, 600);
            secondNumber = random.Next(100, 600);

        }
        else
        {
            
            Console.WriteLine(" Please select difficulty");
        }
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        result = Helpers.ValidateResults(result);
        
        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press enter for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect :(. Press enter for the next question");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score} Press enter to return to the menu..");
            Helpers.StopTimer();
            Console.ReadLine();
        }
        
    }
    Helpers.AddToHistory(score, GameType.Subtraction);
}
internal void MultiplicationGame(string message)
{
    var random = new Random();
    var score = 0;
    
    Console.Clear();
    Console.WriteLine(@$"Please choose which difficulty you would like:
1 - Easy
2 - Normal
3 - Hard");
    var diffSelect = Console.ReadLine();
    diffSelect = Helpers.GetDifficulty(diffSelect);
    Helpers.StartTimer();
    for (int i = 0; i < 5; i++)
    {
        
        int firstNumber = 0;
        int secondNumber = 0;

        Console.Clear();
        Console.Write(message);
        if (diffSelect == "1")
        {
            Console.WriteLine(" - Easy difficulty");
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
        }
        else if (diffSelect == "2")
        {
            Console.WriteLine(" - Normal difficulty");
            firstNumber = random.Next(1, 30);
            secondNumber = random.Next(1, 30);
        }
        else if (diffSelect == "3")
        {  
            Console.WriteLine(" - Hard difficulty");
            firstNumber = random.Next(100, 150);
            secondNumber = random.Next(100, 150);

        }
        else
        {
            
            Console.WriteLine(" Please select difficulty");
        }
        
        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        result = Helpers.ValidateResults(result);
        
        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press enter for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect :(. Press enter for the next question");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score} Press enter to return to the menu..");
            Helpers.StopTimer();
            Console.ReadLine();
        }
    }
    Helpers.AddToHistory(score, GameType.Multiplication);
}
internal void DivisionGame(string message)
{
    Console.Clear();
    Console.Write(message);
    Console.WriteLine(@$"Please choose which difficulty you would like:
1 - Easy
2 - Normal
3 - Hard");
    var diffSelect = Console.ReadLine();
    diffSelect = Helpers.GetDifficulty(diffSelect);
    
    var score = 0;
    Helpers.StartTimer();
    for (int i = 0; i < 5; i ++)
    {
        var divisionNumbers = Helpers.GetDivisionNumbers(diffSelect);
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];
        
        Console.Write(message);
        if (diffSelect == "1")
        {
            Console.WriteLine(" - Easy difficulty");
        }
        else if (diffSelect == "2")
        {
            Console.WriteLine(" - Normal difficulty");
        }
        else if (diffSelect == "3")
        {
            Console.WriteLine(" - Hard difficulty");
        }
        else
        {
            Console.WriteLine(" Please select difficulty");
        }
        
        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();
        
        result = Helpers.ValidateResults(result);
        
        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press enter for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect :(. Press enter for the next question");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score} Press enter to return to the menu..");
            Helpers.StopTimer();
            Console.ReadLine();
        }
    }
    Helpers.AddToHistory(score, GameType.Division);
}
}
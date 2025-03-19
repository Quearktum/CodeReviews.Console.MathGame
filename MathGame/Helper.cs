using MathGame.Models;
namespace MathGame;

internal class Helper
{
    internal static List<Game> games = new();
    internal static void QuitGame()
    {
        Console.WriteLine("Quit selected");
        Environment.Exit(0);
    }


    internal static void GetGames()
    {
        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("-----------------------------------");

        foreach (var game in games)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
        }

        Console.WriteLine("-----------------------------------\n");
        Console.ReadLine();
    }

    internal static void AddHistory(int score, GameType type)
    {
        games.Add(new Game
        {
            Date = DateTime.Now,
            Score = score,
            Type = type
        });
    }

    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        int firstNumber = random.Next(0, 99);
        int secondNumber = random.Next(1, 99);

        int[] result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(0, 99);
            secondNumber = random.Next(0, 99);
        }
        result[0] = firstNumber;
        result[1] = secondNumber;


        return result;
    }

    internal static string ValidateResult(string result)
    {
        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Invalid answer! Please try again");
            Console.ReadLine();
        }

        return result;
    }

    internal static string GetName()
    {
        Console.WriteLine("Please type your name:");
        string name = Console.ReadLine();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name could not be empty");
            name = Console.ReadLine();
        }

        return name;
    }
}

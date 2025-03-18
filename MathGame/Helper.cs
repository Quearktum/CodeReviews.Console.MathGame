using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame;

internal class Helper
{
    internal static List<Game> games = new()
    {
        new Game{ Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        new Game{ Date = DateTime.Now.AddDays(2), Type = GameType.Addition, Score = 1 },
        new Game{ Date = DateTime.Now.AddDays(3), Type = GameType.Subtraction, Score = 2 },
        new Game{ Date = DateTime.Now.AddDays(4), Type = GameType.Addition, Score = 3 },
        new Game{ Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 4 },
        new Game{ Date = DateTime.Now.AddDays(6), Type = GameType.Division, Score = 5 },
        new Game{ Date = DateTime.Now.AddDays(7), Type = GameType.Subtraction, Score = 5 },
        new Game{ Date = DateTime.Now.AddDays(8), Type = GameType.Addition, Score = 2 },
        new Game{ Date = DateTime.Now.AddDays(9), Type = GameType.Multioplication, Score = 5 },
        new Game{ Date = DateTime.Now.AddDays(10), Type = GameType.Multioplication, Score = 5 },
        new Game{ Date = DateTime.Now.AddDays(11), Type = GameType.Addition, Score = 3 },
        new Game{ Date = DateTime.Now.AddDays(12), Type = GameType.Addition, Score = 5 },
        new Game{ Date = DateTime.Now.AddDays(13), Type = GameType.Division, Score = 4 },
        new Game{ Date = DateTime.Now.AddDays(14), Type = GameType.Addition, Score = 5 },
        new Game{ Date = DateTime.Now.AddDays(15), Type = GameType.Division, Score = 3 },
    };

    internal static void QuitGame()
    {
        Console.WriteLine("Quit selected");
        Environment.Exit(0);
    }


    internal static void GetGames()
    {
        var gamesToPrint = games.Where(x => x.Type == GameType.Addition).OrderByDescending(x => x.Score);
        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("-----------------------------------");

        foreach (var game in gamesToPrint)
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

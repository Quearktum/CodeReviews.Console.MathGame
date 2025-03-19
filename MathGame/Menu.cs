namespace MathGame
{
    internal class Menu
    {
        internal void Init(string name, DateTime date)
        {
            GameEngine engine = new GameEngine();   

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math game. That's greate that you're working on improving yourself\n");

            var isGameOn = true;

            while (isGameOn)
            {
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
                V - View History
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                Q -  Quit the program");
                Console.WriteLine("--------------------------------------------------");

                string gameSelected = Console.ReadLine().Trim().ToLower();

                switch (gameSelected)
                {
                    case "v":
                        Helper.GetGames();
                        break;
                    case "a":
                        engine.AdditionGame();
                        break;
                    case "s":
                        engine.SubtractionGame();
                        break;
                    case "m":
                        engine.MultiplicationGame();
                        break;
                    case "d":
                        engine.DivisionGame();
                        break;
                    case "q":
                        Helper.QuitGame();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        isGameOn = false;
                        break;
                }
            }
        }


    }
}

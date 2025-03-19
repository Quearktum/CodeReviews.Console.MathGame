using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame()
        {
            Console.WriteLine("Addition game selected");
            int score = 0;

            var Random = new Random();
            int firstNum;
            int secondNum;

            for (int i = 0; i < 5; i++)
            {
                firstNum = Random.Next(0, 10);
                secondNum = Random.Next(0, 10);
                Console.WriteLine($"{firstNum} + {secondNum}");
                var result = Console.ReadLine();

                result = Helper.ValidateResult(result);

                if (int.Parse(result) == firstNum + secondNum)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                    Console.WriteLine("Incorrect :(");
            }

            Console.WriteLine($"Game Over! Your score is {score}");
            Helper.AddHistory(score, GameType.Addition);

        }

        internal void SubtractionGame()
        {
            Console.WriteLine("Subtraction game selected");
            int score = 0;

            var Random = new Random();
            int firstNum;
            int secondNum;

            for (int i = 0; i < 5; i++)
            {
                firstNum = Random.Next(0, 10);
                secondNum = Random.Next(0, 10);
                Console.WriteLine($"{firstNum} - {secondNum}");
                var result = Console.ReadLine();

                result = Helper.ValidateResult(result);

                if (int.Parse(result) == firstNum - secondNum)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                    Console.WriteLine("Incorrect :(");
            }

            Console.WriteLine($"Game Over! Your score is {score}");
            Helper.AddHistory(score, GameType.Subtraction);

        }

        internal void MultiplicationGame()
        {
            Console.WriteLine("Multiplication game selected");
            int score = 0;

            var Random = new Random();
            int firstNum;
            int secondNum;

            for (int i = 0; i < 5; i++)
            {
                firstNum = Random.Next(0, 10);
                secondNum = Random.Next(0, 10);
                Console.WriteLine($"{firstNum} * {secondNum}");
                var result = Console.ReadLine();

                result = Helper.ValidateResult(result);

                if (int.Parse(result) == firstNum * secondNum)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                    Console.WriteLine("Incorrect :(");
            }

            Console.WriteLine($"Game Over! Your score is {score}");
            Helper.AddHistory(score, GameType.Multioplication);


        }

        internal void DivisionGame()
        {
            Console.WriteLine("Division game selected");

            int score = 0;


            for (int i = 0; i < 5; i++)
            {
                int[] numbers = Helper.GetDivisionNumbers();
                int firstNum = numbers[0];
                int secondNum = numbers[1];

                Console.WriteLine($"{firstNum} / {secondNum}");
                var result = Console.ReadLine();

                result = Helper.ValidateResult(result);

                if (int.Parse(result) == firstNum / secondNum)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                    Console.WriteLine("Incorrect :(");
            }

            Console.WriteLine($"Game Over! Your score is {score}");
            Helper.AddHistory(score, GameType.Division);
        }


    }
}

using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Arsam Sarabi";

            // App Header
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("{0} - v{1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();


            Console.WriteLine("What is you name?");
            string username = Console.ReadLine();
            Console.WriteLine("Hello {0}, Let's play a game!", username);

            string playAgain = "Y";

            while(playAgain == "Y")
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please enter a number!");
                        Console.ResetColor();
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess > correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Too high! try again.");
                        Console.ResetColor();
                    }
                    else if (guess < correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Too low! try again.");
                        Console.ResetColor();
                    }
                }

                Console.ResetColor();
                Console.WriteLine("Correct!");
                Console.WriteLine("Play again? (Y/N)");
                playAgain = Console.ReadLine().ToUpper();
            }
        }
    }
}

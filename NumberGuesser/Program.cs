using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintAppInfo();

            string username = GetUsername();
            

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
                        PrintColorMessage("Please enter a number!", ConsoleColor.DarkRed);
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess > correctNumber)
                    {
                        PrintColorMessage("Too high! try again", ConsoleColor.DarkRed);
                    }
                    else if (guess < correctNumber)
                    {
                        PrintColorMessage("Too low! try again", ConsoleColor.DarkRed);
                    }
                }

                PrintColorMessage("Correct!", ConsoleColor.Green);
                Console.WriteLine("Play again? (Y/N)");
                playAgain = Console.ReadLine().ToUpper();
            }
        }

        static void PrintAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Arsam Sarabi";

            string message = appName + " - v" + appVersion + " by " + appAuthor;
            PrintColorMessage(message, ConsoleColor.DarkCyan, ConsoleColor.White);
        }

        static string GetUsername()
        {
            Console.WriteLine("What is you name?");
            string username = Console.ReadLine();
            Console.WriteLine("Hello {0}, Let's play a game!", username);

            return username;
        }

        static void PrintColorMessage(string message, ConsoleColor color, ConsoleColor bgColor = ConsoleColor.Black)
        {
            Console.BackgroundColor = bgColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}

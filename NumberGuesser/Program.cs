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

            int correctNumber = 7;
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber)
            {
                string input = Console.ReadLine();
                guess = Int32.Parse(input);


            }


        }
    }
}

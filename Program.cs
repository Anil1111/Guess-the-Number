using System;

//Name space
namespace Guess_the_Number
{
    //Main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {

                //Generate random number
                Random random = new Random();

                int correctNum = random.Next(1, 10);

                //init guess 
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Select a Number Between 1-10: ");

                while (guess != correctNum)
                {
                    // get user input
                    string input = Console.ReadLine();

                    // Type checking for int
                    if (!int.TryParse(input, out guess)) {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Not a number, try again");

                        continue;
                    }

                    // Cast to int, set guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNum) {
                        //Print Error Message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again");
                    }
                }

                // Output Success Message
                PrintColorMessage(ConsoleColor.Green, "Correct!!!");

                //Ask user to play again
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
            }
        }

        //Get and display info
        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Guess the Number";
            string appVersion = "1.0.0";
            string appAuthor = "Bernard Johnson";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Write app name, versions, and author
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        //Get user's name and display greeting
        static void GreetUser()
        {
            //Ask user for name
            Console.Write("Please Enter Your Name: ");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game!");
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            //Tell user the output is not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}

using System;


//Namespace
namespace NumberGuess
{
    //Main Class
    class Program
    {
        //Entru Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo Function to get info

            GreetUser(); // Ask for Users name and greet

            while (true)
            
            {

                //Create a new Random object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess Var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while(guess != correctNumber) {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure input is a number
                    if (!int.TryParse(input, out guess)) {

                        //Print error Message 
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        //Keep going
                        continue;

                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correctNumber
                    if (guess != correctNumber)
                    {
                        //Print error Message 
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                    }
                }

                //Print error Message 
                PrintColorMessage(ConsoleColor.Blue, "Congrats, you are correct!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else {
                    return;
                }
            }
        }

        // Get and display app info0
        static void GetAppInfo() {
            //Set App Vars
            string appName = "NumberGuess";
            string appVersion = "1.0.0";
            string appAuthor = "Vlado Djuric";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();

        }

        // Ask user name and Greet
        static void GreetUser() {
            //Ask Users Name
            Console.WriteLine("What is your name?");

            //Get User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);

        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user to input a number
            Console.WriteLine(message);

            //Reset Text Color
            Console.ResetColor();
        }
    }
}

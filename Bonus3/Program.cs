using System;

namespace Bonus3
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            string userInput = "y";

            Random Rnd = new Random(Guid.NewGuid().GetHashCode());
            int secretNumber = Rnd.Next(1, 101);

            Console.WriteLine("Welcome to the Guess a Number Game!");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++\n");

            while (userInput == "y")
            {
                Console.WriteLine("I'm thinking of a number between 1 and 100.\nTry to guess it.\n");
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

                if (guess > 0 && guess < 100)
                {

                    while (guess != secretNumber)
                    {
                        if (guess > secretNumber)
                        {
                            Console.WriteLine("You guessed too high.\nGuess Again: ");
                            guess = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("You guessed too low.\nGuess Again: ");
                            guess = int.Parse(Console.ReadLine());
                        }
                    }

                    if (guess == secretNumber)
                    {
                        Console.WriteLine("You guessed correct!");
                        Console.WriteLine("Do you want to play again? (y/n)");
                        userInput = Console.ReadLine().ToLower();

                        if (userInput == "n")
                        {
                            Console.WriteLine("Thank you for playing!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!  Please enter a number between 1 and 100!");
                    guess = int.Parse(Console.ReadLine());
                }


            }

            Console.ReadKey();

        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Random number = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magic = number.Next(1, 101);

            Console.Write("I am thinking of a number between 1 and 100. Can you guess it? ");

            int guess = 0;
            int guessCount = 0;

            while (guess != magic)
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());


                guessCount++;

                if (guess < magic)
                {
                    Console.WriteLine("The magic number is higher, try again! ");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("The magic number is lower, try again! ");
                }
                else
                {
                    Console.WriteLine("Yep that's right! You guessed it! Great job!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            Console.Write("Would you like to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();
            playAgain = (playAgainInput == "yes");
        }

        Console.WriteLine("Thank you for playing!");
    }
}
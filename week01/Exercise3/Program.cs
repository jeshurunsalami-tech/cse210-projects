using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        string playAgain = "yes";
        while (playAgain == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                guessCount += 1;
            }

            Console.Write($"You guessed it in {guessCount} times");
            Console.WriteLine();
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
    }
}
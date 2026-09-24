using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);
        int guess = -1;
        string guess_string;
        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            guess_string = Console.ReadLine();
            guess = int.Parse(guess_string);
            if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess == magic)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Error");
            }
         }    }
}
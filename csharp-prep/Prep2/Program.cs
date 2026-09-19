using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("What is your Grade %? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        char letter;

        if (grade >= 90)
        {
            letter = 'A';
        }
        else if (grade >= 80)
        {
            letter = 'B';
        }
        else if (grade >= 70)
        {
            letter = 'C';
        }
        else if (grade >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"You have an {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!");
        }
        else
        {
            Console.WriteLine("Better Luck Next Time");
        }
    }
}
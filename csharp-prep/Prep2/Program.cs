using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("What is your Grade %? ");
        int grade = Console.ReadLine();
        char letter;

        if (grade >= 90)
        {
            letter = A;
        }
        else if (grade >= 80)
        {
            letter = B;
        }
        else if (grade >= 70)
        {
            letter = C;
        }
        else if (grade >= 60)
        {
            letter = D;
        }
        else if (grade < 60)
        {
            letter = F;
        }

        Console.WriteLine($"You have an {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("congratulations!");
        }
        else
        {
            Console.WriteLine("Better Luck Next Time");
        }
    }
}
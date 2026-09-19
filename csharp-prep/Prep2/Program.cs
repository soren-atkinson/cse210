using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("What is your Grade %? ");
        int grade = Console.ReadLine();


        if (grade >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You have an B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You have an C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You have an D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("You have an F");
        }

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
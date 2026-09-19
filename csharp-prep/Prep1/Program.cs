using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First Name? ");
        string fName = Console.ReadLine();

        Console.Write("What is your Last Name? ");
        string lName = Console.ReadLine();
        
        Console.WriteLine($"Your name is {lName}, {fName} {lName}.");
    }
}
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = -1;

        while (input != 0)
        {
            Console.Write("Add: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"Sum is {sum}.");
        int average = sum / numbers.Count;
        Console.WriteLine($"Average is {average}.");
        int largeist = 0;
        foreach (int number in numbers)
        {
            if (number > largeist)
            {
                largeist = number;
            }
        }
        Console.WriteLine($"Largeist Number is {largeist}");
    }
}
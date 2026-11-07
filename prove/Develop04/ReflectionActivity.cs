using System;
using System.Collections.Generic;
using System.IO;


public class ReflectionActivity : Activity{
    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        ){}

    public void InteractReflection(){
        InteractProlouge();
        List<string> prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you felt the Holy Ghost.",
            "Think of a time when you felt very happy.",
            "Think of a time when you saw someone do something brave.",
            "Think of a time when you made a difference in someone's life."
        };
        List<string> questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this experience different from other experiences?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "How did this experience help you feel gratitude?",
            "What did you learn about others through this experience?",
            "What was your favorite part of this experience?"
        };
        Random random = new Random();
        
        Console.WriteLine("Consider the Following Prompt:\n");
        int index = random.Next(prompts.Count);
        Console.WriteLine($"--- {prompts[index]} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\n");
        Console.Write("You may begin in: ");
        ShowCounter(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            int questionIndex = random.Next(questions.Count);
            Console.WriteLine($"\n{questions[questionIndex]}");
            ShowSpinner(5);
        }
        InteractEpilouge();
    }
}

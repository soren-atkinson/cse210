using System;
using System.Collections.Generic;
using System.IO;


public class ListerActivity : Activity{
    public ListerActivity() : base(
        "Lister Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        ){}

    public void InteractLister(){
        InteractProlouge();
        List<string> prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are things that you are grateful for?",
            "What are good things about your family?",
            "What are things that make you happy?",
            "What are things that you enjoy doing?",
            "Who are people that you love?",
            "What are things that you are looking forward to?",
            "What are things that you have accomplished recently?"
        };
        Random random = new Random();

        Console.WriteLine("List as many answers as you can to the following prompt: ");
        int index = random.Next(prompts.Count);
        Console.WriteLine($"--- {prompts[index]} ---");
        Console.Write("You may begin in: ");
        ShowCounter(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        int i = 0;
        while ((DateTime.Now - startTime).TotalSeconds < _duration){
            Console.Write("> ");
            Console.ReadLine();
            i++;
        }
        Console.WriteLine($"You have listed {i} items!");
        InteractEpilouge();
    }
}

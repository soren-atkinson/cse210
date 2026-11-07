using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class Activity{
    private string _title;
    private string _desc;
    protected int _duration;
    

    public Activity(string title, string desc){
        _title = title;
        _desc = desc;
        _duration = 0;
    }
    
    public int GetDuration(){
        return _duration;   
    }
    public void InteractProlouge(){
        Console.WriteLine($"Welcome to the {_title}.\n\n {_desc}\n");
        Console.Write("How long, in seconds, would you like for your session: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet Ready...");
        ShowSpinner(5);
    }
    public void InteractEpilouge(){
        Console.WriteLine("\n\nWell Done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou completed another {_duration} seconds in {_title}.");
        ShowSpinner(3);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {DateTime startTime = DateTime.Now;

    while ((DateTime.Now - startTime).TotalSeconds < seconds)
    {
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
    }
    }
    public void ShowCounter(int seconds){
    for (int i = seconds; i > 0; i--){
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
}
}

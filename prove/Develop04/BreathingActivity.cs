using System;
using System.Collections.Generic;
using System.IO;

public class BreathingActivity : Activity{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        ){}

    public void InteractBreathing(){
        InteractProlouge();
        DateTime startTime = DateTime.Now;
        
        while((DateTime.Now - startTime).TotalSeconds < _duration){
        Console.Write("\n\nBreath In...");
        ShowCounter(5);
        Console.Write("\nBreath Out...");
        ShowCounter(5);
        }
        InteractEpilouge();
    }
}
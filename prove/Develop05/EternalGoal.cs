using System;


public class EternalGoal : Goal{
    public EternalGoal(string title, string desc, int points) : base(title,desc,points){}

    public override string GetSaveString(){
        return $"EternalGoal | {_title} | {_desc} | {_points}";
    }

    public override void Display(){
        Console.WriteLine($"[ ] {_title} ({_desc})");
    }

    public override int Progress(){
        return _points;
    }
}
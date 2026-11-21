using System;


public class SimpleGoal : Goal{
    private bool _completed;

    public SimpleGoal(string title, string desc, int points) : base(title, desc, points){
        _completed = false;
    }
    public SimpleGoal(string title, string desc, int points, bool completed) : base(title, desc, points){
        _completed = completed;
    }

    public override string GetSaveString(){
        return $"SimpleGoal | {_title} | {_desc} | {_points} | {_completed}";
    }

    public override void Display(){
        if(_completed == true){
            Console.WriteLine($"[X] {_title} ({_desc})");
        }
        else{
            Console.WriteLine($"[ ] {_title} ({_desc})");
        }
    }

    public override int Progress(){
        if(_completed != true){
            _completed = true;
            return _points;
        }
        else{
            return 0;
        }
    }
}
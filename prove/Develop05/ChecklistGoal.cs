using System;


public class ChecklistGoal : Goal{
    private int _amountCompleted;
    private int _amountNeeded;
    private int _bonusPoints;

    public ChecklistGoal(string title, string desc, int amount, int points, int bonus) : base(title, desc, points){
        _amountCompleted = 0;
        _amountNeeded = amount;
        _bonusPoints = bonus;
    }
    public ChecklistGoal(string title, string desc, int amountCompleted, int amount,  int points, int bonus) : base(title, desc, points){
        _amountCompleted = amountCompleted;
        _amountNeeded = amount;
        _bonusPoints = bonus;
    }

    public override string GetSaveString(){
        return $"ChecklistGoal|{_title}|{_desc}|{_amountCompleted}|{_amountNeeded}|{_points}|{_bonusPoints}";
    }

    public override void Display(){
        if(_amountCompleted >= _amountNeeded){
            Console.WriteLine($"[X] {_title} ({_desc}) --- Currently Completed {_amountCompleted}/{_amountNeeded}");
        }
        else {
            Console.WriteLine($"[ ] {_title} ({_desc}) --- Currently Completed {_amountCompleted}/{_amountNeeded}");
        }
    }

    public override int Progress(){
        
        if (_amountCompleted >= _amountNeeded)
        {
            return 0;
        }

        _amountCompleted++;

        if (_amountCompleted == _amountNeeded)
        {
            return _points + _bonusPoints;
        }

        return _points;
    }
        
    }



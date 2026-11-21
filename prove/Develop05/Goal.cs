using System;


public abstract class Goal{
    protected string _title;
    protected string _desc;
    protected int _points;

    public Goal(string title, string desc, int points){
        _title = title;
        _desc = desc;
        _points = points;
    }

    public abstract string GetSaveString();
    public abstract void Display();
    public abstract int Progress();
}
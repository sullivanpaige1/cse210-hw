using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public virtual int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public virtual string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

    public virtual string GetDetails()
    {
        return $"{GetStatus()} {_name} ({_description})";
    }

    public virtual string GetSaveString()
    {
        return $"{_name}|{_description}|{_points}|{_isComplete}";
    }
}
class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string d, int m)
    {
        _date = d;
        _minutes = m;
    }

    public virtual double GetDistance() { return 0; }
    public virtual double GetSpeed() { return 0; }
    public virtual double GetPace() { return 0; }

    public string GetSummary()
    {
        return _date + " Distance: " + GetDistance();
    }
}
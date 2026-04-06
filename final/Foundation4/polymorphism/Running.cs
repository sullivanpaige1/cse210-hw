class Running : Activity
{
    private double _distance;

    public Running(string d, int m, double dist)
        : base(d, m)
    {
        _distance = dist;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}
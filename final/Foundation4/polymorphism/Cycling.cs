class Cycling : Activity
{
    private double _speed;

    public Cycling(string d, int m, double s)
        : base(d, m)
    {
        _speed = s;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}
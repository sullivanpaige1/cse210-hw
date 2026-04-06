class Swimming : Activity
{
    private int _laps;

    public Swimming(string d, int m, int l)
        : base(d, m)
    {
        _laps = l;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }
}
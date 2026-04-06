class Outdoor : Event
{
    private string _weather;

    public Outdoor(string t, string d, string da, string ti, Address a, string w)
        : base(t, d, da, ti, a)
    {
        _weather = w;
    }

    public string GetFull()
    {
        return GetStandard() + "\nWeather: " + _weather;
    }
}
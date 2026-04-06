using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string t, string d, string da, string ti, Address a, string s, int c)
        : base(t, d, da, ti, a)
    {
        _speaker = s;
        _capacity = c;
    }

    public string GetFull()
    {
        return GetStandard() + "\nLecture: " + _speaker;
    }
}
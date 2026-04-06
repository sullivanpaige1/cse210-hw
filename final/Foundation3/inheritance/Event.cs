using System;

class Event
{
    protected string _title;
    protected string _desc;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string t, string d, string da, string ti, Address a)
    {
        _title = t;
        _desc = d;
        _date = da;
        _time = ti;
        _address = a;
    }

    public string GetStandard()
    {
        return _title + "\n" + _desc + "\n" + _date + " " + _time + "\n" + _address.ToString();
    }
}
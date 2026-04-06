class Reception : Event
{
    private string _email;

    public Reception(string t, string d, string da, string ti, Address a, string e)
        : base(t, d, da, ti, a)
    {
        _email = e;
    }

    public string GetFull()
    {
        return GetStandard() + "\nRSVP: " + _email;
    }
}
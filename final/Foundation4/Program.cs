using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> list = new List<Activity>();

        list.Add(new Running("Apr 1", 30, 3.0));
        list.Add(new Cycling("Apr 2", 40, 10.0));
        list.Add(new Swimming("Apr 3", 20, 10));

        foreach (Activity a in list)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
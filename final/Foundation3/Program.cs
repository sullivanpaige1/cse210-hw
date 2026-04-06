using System;

class Program
{
    static void Main(string[] args)
    {
        Address a = new Address("123 Center St", "Rexburg", "ID", "USA");

        Lecture lec = new Lecture("Talk", "Programming With AI", "Apr 1", "6pm", a, "Dr. Smith", 50);
        Reception rec = new Reception("Meetup", "Networking", "Apr 2", "7pm", a, "email@test.com");
        Outdoor outd = new Outdoor("Picnic", "Fun", "Apr 3", "12pm", a, "Sunny");

        Console.WriteLine(lec.GetFull());
        Console.WriteLine(rec.GetFull());
        Console.WriteLine(outd.GetFull());
    }
}
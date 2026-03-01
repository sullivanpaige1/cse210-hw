using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people you are grateful for.",
        "List things that make you happy.",
        "List personal strengths you have."
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity helps you reflect by listing positive things.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        int count = 0;

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

        Console.WriteLine("\nStart listing items. Press Enter after each one.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");

        DisplayEndingMessage();
    }
}
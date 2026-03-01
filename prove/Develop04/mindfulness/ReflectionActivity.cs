using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you felt proud of yourself."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful?",
        "What did you learn about yourself?",
        "How did you feel afterward?",
        "How can you apply this in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity helps you reflect on meaningful experiences.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine("\nConsider the following prompt:\n");
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);

        Console.WriteLine("\nWhen you have something in mind, press Enter.");
        Console.ReadLine();

        Console.WriteLine("\nNow reflect on the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int questionIndex = random.Next(_questions.Count);
            Console.WriteLine("\n" + _questions[questionIndex]);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
using System;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I talked to today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord today?",
        "What made me smile today?",
        "What challenge did I overcome today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}

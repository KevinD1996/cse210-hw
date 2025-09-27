using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private Random random = new Random();

    private List<string> _prompts = new List<string>
    {

        "What challenge did you overcome today?",
        "What are you grateful for right now?",
        "Describe a moment of peace you experienced today.",
        "What is one thing you learned today?",
        "If you could change one thing about today, what would it be?",
        "What is a goal you have for tomorrow?",
        "What emotions did you feel today and why?",
        "Describe a conversation that impacted you today.",
        "What is a small act of kindness you witnessed or performed today?"
    };

    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}


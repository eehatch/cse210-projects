using System.Diagnostics;

public class Reflection :Activity
{
    private List<string> _firstPrompt = new();
    private List<string> _secondPrompt = new();


    public Reflection(string Name, string WelcomeMessage) : base(Name, WelcomeMessage)
    {
        _firstPrompt.Add("Think of a time when you stood up for someone else.");
        _firstPrompt.Add("Think of a time when you did something really difficult.");
        _firstPrompt.Add("Think of a time when you helped someone in need.");
        _firstPrompt.Add("Think of a time when you did something truly selfless.");

        _secondPrompt.Add("Why was this experience meaningful to you?");
        _secondPrompt.Add("Have you ever done anything like this before?");
        _secondPrompt.Add("How did you get started?");
        _secondPrompt.Add("How did you feel when it was complete?");
        _secondPrompt.Add("What made this time different than other times when you were not as successful?");
        _secondPrompt.Add("How can you keep this experience in mind in the future?");
        _secondPrompt.Add("What could you learn from this experience that applies to other situations?");    }
    public List<string> PromptSelector()
    {
        return _firstPrompt;
    }
    public List<string> QuestionSelector()
    {
        return _secondPrompt;
    }

    public void Reflect()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Reflection Activity");
        Console.WriteLine();
        DisplayStartingMessage();
        while ()
        DisplayEndMessage();
    }

}
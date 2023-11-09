public class Reflection : Activity
{
    private string[] _showPrompt;
    private string[] _showQuestion;

    public Reflection(string StartMessage, int Duration, string[] ShowPrompt, string[] ShowQuestions): base(StartMessage, Duration)
    {
        List<string> reflectionPrompts = new List<string>();
        reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        reflectionPrompts.Add("Think of a time when you did something really difficult.");
        reflectionPrompts.Add("Think of a time when you helped someone in need.");
        reflectionPrompts.Add("Think of a time when you did something truly selfless.");
        List<string> reflectionQuestions = new List<string>();
        reflectionQuestions.Add("Why was this experience meaningful to you?");
        reflectionQuestions.Add("Have you ever done anything like this before?");
        reflectionQuestions.Add("How did you get started?");
        reflectionQuestions.Add("How did you feel when it was complete?");
        reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        reflectionQuestions.Add("How can you keep this experience in mind in the future?");
        reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
    }
    public override void StartMessage()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }
    public string[] GetRandomPrompt()
    {
        return _showPrompt;
    }
    public string[] GetRandomQuestion()
    {
        return _showQuestion;
    }
}
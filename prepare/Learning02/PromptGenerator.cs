public class PromptGenerator
{
    public List<string> _prompts;
    
    public string GetRandomPrompt()
    {
        private string[] prompts;
    private Random random;

    public PromptGenerator()
    {
        prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        random = new Random();
    }

    public string GeneratePrompt()
    {
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}
        return "";
    }

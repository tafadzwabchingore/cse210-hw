public class Reflection
{
    public Reflection() {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    }
    
    do {
        public static void Main() {

            string[] prompts = {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            }

            string[] questions = {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }
            
    
        var sentenceGenerator = new SentenceGenerator(prompts);

        for (int i = 5; i > 0; i--)
        {
        Console.WriteLine("Get ready");
        Console.Write(".");
        Thread.Sleep(1000);
        }

        var sentenceGenerator = new SentenceGenerator(questions);

        for (int i = 5; i > 0; i--)
        {
        Console.WriteLine("Get ready");
        Console.Write("|/-\-|");
        Thread.Sleep(1000);
        }
    
            // Generate and print a random sentence.
            string randomSentence = sentenceGenerator.GenerateRandomSentence();
            Console.WriteLine(randomSentence);
    } 
    while (time > 0);

    Console.WriteLine("You have completed " + session + "seconds of the breathing activity. Keep up the good work.");
}
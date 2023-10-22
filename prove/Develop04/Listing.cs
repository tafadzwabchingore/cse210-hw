public class Listing : Activity
{

    // description = Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

}
public string void Run()
{
    var sentenceGenerator = new SentenceGenerator(prompts);

    object SentenceGenerator = null;
    // Generate and print a random sentence.
    string randomSentence = SentenceGenerator.GenerateRandomSentence();
    Console.WriteLine(randomSentence);

    for (int i = 5; i > 0; i--)
    {
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
}


while (time > 0) ;

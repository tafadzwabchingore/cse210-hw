public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private char[] spinner = new char[] { '|', '/', '-', '\\' };

    public Activity() { }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like to perform this activity?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Welldone!!!!")
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity. Keep up the good work.");
        ShowSpinner(5)
    }

    public void ShowSpinner(int duration)
    {
        for (int a = duration; a > 0; a--)
        {
            foreach (char character in spinner)
            {
                Console.Write(Character);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowTimer(int duration)
    {
        for (int a = duration; a > 0; a--)
        {
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
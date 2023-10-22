public class Breathing : Activity
{

    public Breathing()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
    }

    public void Run()
    {
        DisplayStartMessage();
        for (int _ = _duration; _ > 0; _ -= 10)
        {
            Console.WriteLine("Breath in...");
            ShowTimer(4);

            Console.WriteLine("Breath out...");
            ShowTimer(6);
        }
        DisplayEndMessage();
    }
}
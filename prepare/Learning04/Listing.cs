Public class Listing {

    Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    
    Console.WriteLine("How much time in seconds would you like to spend in this activity?");
    int time = Convert.ToInt32(Console.ReadLine());

    do {
        public static void Main() {

                string[] prompts = {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                };

            }
        
        var sentenceGenerator = new SentenceGenerator(prompts);

        // Generate and print a random sentence.
        string randomSentence = sentenceGenerator.GenerateRandomSentence();
        Console.WriteLine(randomSentence);
        
        for (int i = 5; i > 0; i--)
            {
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
    }
    while(time > 0);
    
    Console.WriteLine("Hurray!!! You have completed this activity.");
    Console.WriteLine("You have completed " + session + "seconds of the breathing activity. Keep up the good work.");
}
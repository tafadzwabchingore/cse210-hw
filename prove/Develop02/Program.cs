using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        Console.WriteLine("Welcome to the Journal Program!");
        
        while (true)
        {
            Console.WriteLine("What would you like to do?");
            
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;

                case 2:
                    journal.DisplayEntries();
                    break;

                case 3:
                    Console.Write("Enter the filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case 4:
                    Console.Write("Enter the filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
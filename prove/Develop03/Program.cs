using System;
using System.Collections.Generic;
 
namespace ScriptureApp
{
    // <summary>
    // Represents a scripture, including the reference and the text.
    // </summary>
    public class Scripture
    {
        public string Reference { get; private set; }
        public string Text { get; private set; }
 
        // <summary>
        // Constructs a new scripture using the provided reference and text.
        //
        // Parameters:
        // - reference: The reference of the scripture (e.g., "John 3:16").
        // - text: The text of the scripture.
        // </summary>
        public Scripture(string reference, string text)
        {
            Reference = reference;
            Text = text;
        }
    }
 
    public class Program
    {
        private static List<string> hiddenWords = new List<string>();
 
        public static void Main()
        {
            // Create a list of scriptures.
            List<Scripture> scriptures = new List<Scripture>()
            {
                new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
                new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.")
            };
 
            // Prompt the user to press enter or type quit.
            while (true)
            {
                Console.Clear();
                DisplayScriptures(scriptures);
 
                Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");
                string input = Console.ReadLine();
 
                if (input.ToLower() == "quit")
                {
                    break;
                }
 
                HideRandomWords(scriptures);
            }
        }
 
        // <summary>
        // Displays the complete scripture, including the reference and the text.
        //
        // Parameters:
        // - scriptures: The list of scriptures to display.
        // </summary>
        private static void DisplayScriptures(List<Scripture> scriptures)
        {
            foreach (Scripture scripture in scriptures)
            {
                Console.WriteLine($"{scripture.Reference}: {scripture.Text}");
            }
        }
 
        // <summary>
        // Hides a few random words in the scripture.
        //
        // Parameters:
        // - scriptures: The list of scriptures to modify.
        // </summary>
        private static void HideRandomWords(List<Scripture> scriptures)
        {
            hiddenWords.Clear();
 
            foreach (Scripture scripture in scriptures)
            {
                string[] words = scripture.Text.Split(' ');
 
                Random random = new Random();
                int numWordsToHide = random.Next(1, words.Length / 2);
 
                for (int i = 0; i < numWordsToHide; i++)
                {
                    int randomIndex = random.Next(0, words.Length);
                    hiddenWords.Add(words[randomIndex]);
                    words[randomIndex] = "*****";
                }
 
                string scripture.Text = string.Join(" ", words);
            }
 
            Console.Clear();
            DisplayScriptures(scriptures);
            Console.WriteLine("Hidden words: " + string.Join(", ", hiddenWords));
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
using System;
using System.Threading;

namespace ActivityMenuSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Activity Menu");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.Start();
                        break;
                    case "2":
                        ReflectionActivity reflectionActivity = new ReflectionActivity();
                        reflectionActivity.Start();
                        break;
                    case "3":
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.Start();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }

    abstract class Activity
    {
        protected int duration;

        public void Start()
        {
            Console.Clear();
            Console.WriteLine(GetStartingMessage());
            Console.WriteLine("Preparing to begin...");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Activity started. Duration: {0} seconds", duration);
            Thread.Sleep(duration * 1000);
            Console.Clear();
            Console.WriteLine(GetEndingMessage());
            Thread.Sleep(3000);
        }

        protected abstract string GetStartingMessage();
        protected abstract string GetEndingMessage();
    }

    class BreathingActivity : Activity
    {
        protected override string GetStartingMessage()
        {
            return "Breathing Activity\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        protected override string GetEndingMessage()
        {
            return "Good job! You have completed the Breathing Activity.";
        }
    }

    class ReflectionActivity : Activity
    {
        private string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private string[] questions = {
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

        protected override string GetStartingMessage()
        {
            return "Reflection Activity\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }

        protected override string GetEndingMessage()
        {
            return "Good job! You have completed the Reflection Activity.";
        }

        public new void Start()
        {
            base.Start();

            foreach (string prompt in prompts)
            {
                Console.Clear();
                Console.WriteLine(prompt);
                Thread.Sleep(3000);

                foreach (string question in questions)
                {
                    Console.Clear();
                    Console.WriteLine(question);
                    Thread.Sleep(3000);
                }
            }
        }
    }

    class ListingActivity : Activity
    {
        private string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        protected override string GetStartingMessage()
        {
            return "Listing Activity\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        protected override string GetEndingMessage()
        {
            return "Good job! You have completed the Listing Activity.";
        }

        public new void Start()
        {
            base.Start();

            foreach (string prompt in prompts)
            {
                Console.Clear();
                Console.WriteLine(prompt);
                Thread.Sleep(3000);

                Console.WriteLine("Start listing items...");
                Thread.Sleep(duration * 1000);

                Console.Clear();
                Console.WriteLine("Number of items listed: {0}", duration);
                Thread.Sleep(3000);
            }
        }
    }
}


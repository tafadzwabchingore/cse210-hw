using System;
using System.Collections.Generic;

namespace ScriptureHider
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            Console.Clear();
            Console.WriteLine(scripture.ToString());
            Console.WriteLine("Press enter to hide some words or type 'quit' to exit.");
            string input = Console.ReadLine();
            while (input != "quit")
            {
                scripture.HideRandomWord();
                Console.Clear();
                Console.WriteLine(scripture.ToString());
                Console.WriteLine("Press enter to hide some more words or type 'quit' to exit.");
                input = Console.ReadLine();
            }
        }
    }

    class Scripture
    {
        private Reference reference;
        private List<Word> words;

        public Scripture(string book, int chapter, int verse, string text)
        {
            reference = new Reference(book, chapter, verse);
            words = new List<Word>();
            string[] textWords = text.Split(' ');
            for (int i = 0; i < textWords.Length; i++)
            {
                words.Add(new Word(textWords[i]));
            }
        }

        public void HideRandomWord()
        {
            Random random = new Random();
            int index = random.Next(words.Count);
            words[index].Hide();
        }

        public override string ToString()
        {
            string scriptureText = "";
            foreach (Word word in words)
            {
                scriptureText += word.ToString() + " ";
            }
            return reference.ToString() + " " + scriptureText;
        }
    }

    class Reference
    {
        private string book;
        private int chapter;
        private int verse;

        public Reference(string book, int chapter, int verse)
        {
            this.book = book;
            this.chapter = chapter;
            this.verse = verse;
        }

        public override string ToString()
        {
            return book + " " + chapter + ":" + verse;
        }
    }

    class Word
    {
        private string text;
        private bool hidden;

        public Word(string text)
        {
            this.text = text;
            hidden = false;
        }

        public void Hide()
        {
            hidden = true;
        }

        public override string ToString()
        {
            if (hidden)
            {
                return "______";
            }
            else
            {
                return text;
            }
        }
    }
}

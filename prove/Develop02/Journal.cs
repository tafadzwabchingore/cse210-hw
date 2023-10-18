public class Journal 
{
    /*public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {}

    public void DisplayAll()
    {}

    public void SaveToFile(String file)
    {}

    public void LoadFromFile(String file)
    {}
    */

    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found!");
            return;
        }

        entries.Clear();

        using (StreamReader reader = new StreamReader(filename, true))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry entry = new Entry(date, prompt, response);
                    entries.Add(entry);
                }
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}
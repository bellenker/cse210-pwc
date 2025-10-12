using System.IO;

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one new thing I learned today?",
        "What am I grateful for today?",
        "Describe a challenge I overcame today."
    };
    private Random random = new Random();

    public void Add()
    {
        string randomPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"{randomPrompt}");
        Console.Write("Response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry
        {
            Date = DateTime.Now,
            Prompt = randomPrompt,
            Response = response
        };
        Entries.Add(newEntry);
        Console.WriteLine("Journal entry added successfully!");
    }

    public void Display()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
            return;
        }
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void Save()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"Date: {entry.Date}");
                    writer.WriteLine($"Prompt: {entry.Prompt}");
                    writer.WriteLine($"Response: {entry.Response}");
                    writer.WriteLine("-------");
                }
            }
            Console.WriteLine($"Journal entry saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void Load()
    {
        Console.Write("Enter filename to lead (e.g., journal.txt): ");
        string filename = Console.ReadLine();
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            Entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                Entry currentEntry = null;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Date:"))
                    {
                        currentEntry = new Entry();
                        currentEntry.Date = DateTime.Parse(line.Substring("Date: ".Length));
                    }
                    else if (line.StartsWith("Prompt:"))
                    {
                        currentEntry.Prompt = line.Substring("Prompt: ".Length);
                    }
                    else if (line.StartsWith("Response:"))
                    {
                        currentEntry.Response = line.Substring("Response: ".Length);
                    }
                    else if (line == "-------" && currentEntry != null)
                    {
                        Entries.Add(currentEntry);
                        currentEntry = null;
                    }

                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }

}

public class Entry
{
    public Entry(Date, Prompt, Response)
    {

        string prompt = Prompt;
        string response = Response;
    };
}
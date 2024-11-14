public class Journal {

    List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry entry)
    {
    
        _entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Uncomment
    // public void WriteToFile( string fileName)
    // {
    //     using (StreamWriter outputFile = new StreamWriter(fileName))
    //     {
    //         foreach (Entry entry in _entries)
    //         {
    //             outputFile.WriteLine(entry.ToString());
    //         }
    //     }
    // }

    public override string ToString()
    {
        return base.ToString();
    }

    public void ReadEntriesFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts [1];
            string entryText = parts[2];

            // Entry entry = new Entry(date, question, entryText);
            // this.CreateEntry(entry);
        }
    }
}

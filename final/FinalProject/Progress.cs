class Progress
{
    public void DisplayProgress()
    {
        string[] lines = System.IO.File.ReadAllLines("Progress.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
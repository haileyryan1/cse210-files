class Journal{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response){
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        entries.Add(new Entry(date, prompt, response));
    }
    public void DisplayJournal(){
        if (entries.Count == 0){
            Console.WriteLine("No entries in the journal yet.");
        }
        else{
            foreach (var entry in entries){
                entry.DisplayEntry();
            }
        }
    }
    public List<Entry> GetEntries(){
        return entries;
    }
    public void SetEntries(List<Entry> newEntries){
        entries = newEntries;
    }
}

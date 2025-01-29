
class FileManager{
    public void SaveToFile(string filename, List<Entry> entries){
        using (StreamWriter writer= new StreamWriter(filename)){
            foreach (var entry in entries){
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
            Console.WriteLine("Journal saved successfully.");
        }
    }
    public List<Entry> LoadFromFile(string filename){
        List<Entry> entries = new List<Entry>();

        using (StreamReader reader = new StreamReader(filename)){
            string line;
            while ((line = reader.ReadLine()) != null){
                string[] parts = line.Split('|');

                if (parts.Length == 3){
                    entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
        }
        Console.WriteLine("Journal loaded successfully.");
        return entries;
    }
}
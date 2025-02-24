// along with the core requirements I added
// a menu option that allows the user to delete an entry
// updates were made in the Program class and Journal class


using System;

class Program
{
    static void Main(string[] args){
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        FileManager fileManager = new FileManager();
        
        while(true){
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Delete an entry");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice){
                case "1":
                    string prompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;

                case "2":
                    journal.DisplayJournal();
                    break;

                case "3":
                    Console.Write("Enter the filename to save the journal: ");
                    string saveFilename = Console.ReadLine();
                    fileManager.SaveToFile(saveFilename, journal.GetEntries());
                    break;

                case "4":
                    Console.Write("Enter the filename to load the journal: ");
                    string loadFilename = Console.ReadLine();
                    journal.SetEntries(fileManager.LoadFromFile(loadFilename));
                    break;

                case "5":
                    if (journal.GetEntries().Count == 0){
                        Console.WriteLine("No entries to delete");
                        break;
                    }
                    journal.DisplayJournal();
                    Console.Write("Enter the entry number to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int entryIndex)){
                        journal.DeleteEntry(entryIndex - 1);
                    }
                    else{
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;


                case "6":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
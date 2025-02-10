// to exceed the requirements I made a list of scriptures that the user can memorize

using System;
using System.Collections.Generic;

List<Scripture> _scriptures = new List<Scripture>{
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be and men are that they might have joy."),
            new Scripture(new Reference("Moroni", 10, 4, 5), "And when ye shall receive these things I would exhort you that ye would ask God the Eternal Father in the name of Christ if these things are not true.")
        };
Random _random = new Random();

while (true)
{
    Scripture _scripture = _scriptures[_random.Next(_scriptures.Count)];
    while (!_scripture.IsCompletelyHidden())
    {
        Console.Clear();
        Console.WriteLine(_scripture.GetRenderedText());
        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

        string _userInput = Console.ReadLine()?.Trim().ToLower();
        if (_userInput == "quit")
        {
            return;
        }
        _scripture.HideWords();
    }
    Console.Clear();
    Console.WriteLine("You've hidden all the words in this scripture");
    Console.WriteLine("\nPress Enter for a new scripture or type 'quit' to exit.");

    string _userInput2 = Console.ReadLine()?.Trim().ToLower();
    if (_userInput2 == "quit")
    {
        return;
    }
}

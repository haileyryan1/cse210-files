using System;
using System.Collections.Generic;

class Reference{
    public string Book {get; set;}
    public int Chapter {get;set;}
    public int StartVerse {get;set;}
    public int? EndVerse {get;set;}

    public Reference(string book, int chapter, int startVerse){
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = null;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse){
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }
    public string GetReference(){
        return EndVerse.HasValue ? $"{Book} {Chapter}:{StartVerse}--{EndVerse}" : $"{Book} {Chapter}:{StartVerse}";

    }
}

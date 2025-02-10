using System;
using System.Collections.Generic;

class Reference{
    public string _book { get; set; }
    public int _chapter { get; set; }
    public int _startVerse { get; set; }
    public int? _endVerse { get; set; }

    public Reference(string book, int chapter, int startVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetReference(){
        return _endVerse.HasValue ? $"{_book} {_chapter}:{_startVerse}--{_endVerse}" : $"{_book} {_chapter}:{_startVerse}";
    }
}

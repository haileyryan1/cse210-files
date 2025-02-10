using System;
using System.Collections.Generic;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetReference()
    {
        return _endVerse.HasValue ? $"{_book} {_chapter}:{_startVerse}--{_endVerse}" : $"{_book} {_chapter}:{_startVerse}";
    }
}

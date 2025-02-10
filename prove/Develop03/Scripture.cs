using System;
using System.Collections.Generic;
using System.Linq;

class Scripture{
    public Reference _reference { get; set; }
    private List<Word> _words { get; set; }

    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideWords(int count = 3){
        Random _random = new Random();
        List<Word> _visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (_visibleWords.Count > 0){
            int _wordsToHide = Math.Min(count, _visibleWords.Count);
            for (int i = 0; i < _wordsToHide; i++){
                int _index = _random.Next(_visibleWords.Count);
                _visibleWords[_index].Hide();
                _visibleWords.RemoveAt(_index);
            }
        }
    }
    public bool IsCompletelyHidden(){
        return _words.All(word => word.IsHidden());
    }
    public string GetRenderedText(){
        return $"{_reference.GetReference()}\n" + string.Join(" ", _words.Select(w => w.GetRenderedText()));
    }
}


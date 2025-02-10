using System;

class Word{
    public string _text { get; private set; }
    private bool _isHidden { get; set; }

    public Word(string text){
        _text = text;
        _isHidden = false;
    }
    public void Hide(){
        _isHidden = true;
    }
    public bool IsHidden(){
        return _isHidden;
    }
    public string GetRenderedText(){
        return _isHidden ? "____" : _text;
    }
}


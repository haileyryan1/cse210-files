using System;

class Word{
    public string Text {get;private set;}
    private bool isHidden {get;set;}

    public Word(string text){
        Text = text;
        isHidden = false;
    }
    public void Hide(){
        isHidden = true;
    }
    public bool IsHidden(){
        return isHidden;
    }
    public string GetRenderedText(){
        return isHidden ? "____" : Text;
    }
}

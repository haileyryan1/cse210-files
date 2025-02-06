using System;
using System.Collections.Generic;
using System.Linq;

class Scripture{
    public Reference Reference {get;set;}
    private List<Word> Words {get;set;}

    public Scripture(Reference reference, string text){
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideWords(int count=3){
        Random random = new Random();
        List<Word> visibleWords = Words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count > 0){
            int wordsToHide = Math.Min(count, visibleWords.Count);
            for (int i = 0; i < wordsToHide; i++){
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }
    }
    public bool IsCompletelyHidden(){
        return Words.All(word => word.IsHidden());
    }
    public string GetRenderedText(){
        return $"{Reference.GetReference()}\n" + string.Join(" ", Words.Select(w => w.GetRenderedText()));
    }
}

using System;

class Comment
{
    public string _commenterName {get; set;}
    public string _text {get; set;}

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }
}
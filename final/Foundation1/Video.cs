using System;
using System.Collections.Generic;
using System.Transactions;

class Video
{
    public string _title {get; set;}
    public string _author {get; set;}
    public int _length {get; set;}
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment _comment)
    {
        _comments.Add(_comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}
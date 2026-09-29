using System;
using System.Collections.Generic;

public class Video
{
    public string _title = "";
    public string _author = "";
    public int _lengthInSeconds;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}
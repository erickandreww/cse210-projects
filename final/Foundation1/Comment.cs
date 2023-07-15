using System;

class Comment 
{
    // variables to hold the person name and his comment
    public string _personName;
    public string _personComment;

    // a method to return the name and comment in a list
    public List<string> AddComment() 
    {
        List<string> comment = new List<string> {
            $"{_personName}", $"{_personComment}"};
        return comment;
    }
}



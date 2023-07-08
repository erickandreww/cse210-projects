using System;

class Comment 
{
    public string _personName;
    public string _personComment;

    public List<string> AddComment() 
    {
        List<string> comment = new List<string> {
            $"{_personName}", $"{_personComment}"};
        return comment;
    }

    // _holdRefer.Add(new List<string> {"Proverbs", "3","5","6"});
}

// has the responsibility for tracking both 
// the name of the person who made the comment 
// and the text of the comment


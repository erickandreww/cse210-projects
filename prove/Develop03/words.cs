using System;

class Words 
{
    // variable to hold the values
    private string[] _words;
    private string _hiddenWord;
    private string _scripture;


    public Words(string scripture) 
    {
        // get the actual scripture
        _scripture = scripture;
    }

    public string HideRandomWords(int count) 
    {
        // turn the scripture in a list
        _words = _scripture.Split(' ');
        // call random
        Random random = new Random();
        // for loop
        for (int i = 0; i < _words.Length; i++)
        {
            // Hide all the words if the count is equal 3
            if (count == 3) {
                
                if (random.Next(1) == 0) 
                {
                    _words[i] = HideWord(_words[i]);
                }
            }
            // Hide word with 50% probability
            else if (random.Next(2) == 0) 
            {
                _words[i] = HideWord(_words[i]);
            }
        }
        // turn the list back into a string
        // and return the scripture string
        return string.Join(" ", _words);
    }

    private string HideWord(string word)
    {
        // check if the deed is already hidden
        _hiddenWord = "";

        foreach (char c in word)
        {
            // check if the deed is already hidden
            // and turn the word into in underscores
            if (char.IsLetter(c))
            {
                _hiddenWord += "_";
            }
            else
            {
                _hiddenWord += c;
            }
        }
        // return the hidden word
        return _hiddenWord;
    }
}
    
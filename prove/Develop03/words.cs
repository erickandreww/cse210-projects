using System;

class Words 
{
    private string[] _words;
    private string _hiddenWord;
    private string _scripture;


    public Words(string scripture) 
    {
        _scripture = scripture;
    }

    public string HideRandomWords(int count) 
    {
        _words = _scripture.Split(' ');
        Random random = new Random();
        for (int i = 0; i < _words.Length; i++)
        {
            if (count == 3) {
                if (random.Next(1) == 0) // Hide word with 50% probability
                {
                    _words[i] = HideWord(_words[i]);
                }
            }
            else if (random.Next(2) == 0) // Hide word with 50% probability
            {
                _words[i] = HideWord(_words[i]);
            }
        }
        return string.Join(" ", _words);
    }

    private string HideWord(string word)
    {
        _hiddenWord = "";

        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                _hiddenWord += "_";
            }
            else
            {
                _hiddenWord += c;
            }
        }

        return _hiddenWord;
    }
}
    
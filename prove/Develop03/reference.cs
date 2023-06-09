using System;

public class Reference 
{
    // variables to hold the values and information
    private string _reference;
    private string _book;
    private List<List<string>> _holdRefer = new List<List<string>>();
    private int _chapter;
    private int _verse;
    private string _addVerse;

    // Reference 

    private void ReferenceLibrary()
    {
        // Reference Library
        _holdRefer.Add(new List<string> {"John", "8","12",""});
        _holdRefer.Add(new List<string> {"Matthew", "5","14","16"});
        _holdRefer.Add(new List<string> {"John", "7","3",""});
        _holdRefer.Add(new List<string> {"Proverbs", "3","5","6"});
        _holdRefer.Add(new List<string> {"Isaiah", "1","18",""});
        _holdRefer.Add(new List<string> {"Isaiah", "55","8","9"});
        _holdRefer.Add(new List<string> {"2 Nephi", "32","3",""});
        _holdRefer.Add(new List<string> {"Ether", "12","6",""});
    }

    private void randomReference() {
        // Generate a random number
        Random rNumber = new Random();
        int number = rNumber.Next(1, 8);
        // Take a random reference from the library
        List<string> refer = _holdRefer[number];
        // set the values to the variables
        _book = refer[0];
        _chapter = int.Parse(refer[1]);
        _verse = int.Parse(refer[2]);
        _addVerse = refer[3];

        // verify if the scripture have a addVerse
        if (_addVerse != "") {
            
            _reference = $"{_book} {_chapter}:{_verse}-{_addVerse}";
        }
        else {
            _reference = $"{_book} {_chapter}:{_verse}";
        }
    }

    public string GetReference()
    {
        // class the modules and return the reference
        ReferenceLibrary();
        randomReference();
        return _reference;
    }

}
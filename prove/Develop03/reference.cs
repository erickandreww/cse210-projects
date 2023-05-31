using System;

public class Reference 
{
    private string _reference;
    private string _book;
    private string _chapter;
    private string _verse;
    private string _addVerse = "";

    // Reference Constructors
    private Reference() 
    {
        _reference = $"{_book} {_chapter} :{_verse}";
    }
    private Reference(string addVerse) 
    {
        _reference = $"{_book} {_chapter}:{_verse}-{_addVerse}";
    }

    private void ReferenceLibrary()
    {
        // will have a list of references in this list the reference will be in a list.
        // the variables will get the parts by [0].
        // library = ... {"John", "8", "12", ""}
        _book = "John";
        _chapter = "8";
        _verse = "12";

        if (_addVerse != "") {
            Reference(_addVerse);
        }
        else {
            Reference();
        }
    }

    public string GetReference()
    {
        ReferenceLibrary();
        return _reference;
    }

}
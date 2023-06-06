using System;

public class Scripture
{
    private string _scripture;
    private string _scriptureReference;


    private void getScriptureReference()
    {
        Reference addReference = new Reference();
        _scriptureReference = addReference.GetReference();
    }
    private void ScriptureLibrary() 
    {
        Dictionary<string, string> scripturesLibrary = new Dictionary<string, string>() {
            {"John 8:12", "Then spake Jesus again unto them, saying, I am the alight of the world: he that followeth me shall not walk in darkness, but shall have the light of life"}
        };
        _scripture = scripturesLibrary[_scriptureReference];
    }
    public string GetScripture() {
        getScriptureReference();
        ScriptureLibrary();
        return _scripture;
    }

    // A library of scriptures that have two values one with the reference and other with the scripture, and return the scripture of the reference. 
}
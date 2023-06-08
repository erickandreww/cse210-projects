using System;

public class Scripture
{
    // variable to hold and return the scripture
    private string _scripture;
    // variable to get and search fot the reference
    private string _scriptureReference;

    
    public Scripture(string randomReference) 
    {
        // get reference to look up the scripture
        _scriptureReference = randomReference;
    }

    private void ScriptureLibrary() 
    {
        // a Scripture Library in a dictionary format
        Dictionary<string, string> scripturesLibrary = new Dictionary<string, string>() {
            {"John 8:12", "Then spake Jesus again unto them, saying, I am the alight of the world: he that followeth me shall not walk in darkness, but shall have the light of life"},
            {"Matthew 5:14-16", "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven"},
            {"John 7:3", "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent"},
            {"Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths"},
            {"Isaiah 55:8-9", "For my thoughts are not your thoughts, neither are your ways my ways, saith the Lord. For as the heavens are higher than the earth, so are my ways higher than your ways, and my thoughts than your thoughts"},
            {"Isaiah 1:18", "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool"},
            {"2 Nephi 32:3", "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do"},
            {"Ether 12:6", "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith"}
        };
        // set the scripture from the reference to a variable
        _scripture = scripturesLibrary[_scriptureReference];
    }
    public string GetScripture() {
        // return the scripture
        ScriptureLibrary();
        return _scripture;
    }

    // A library of scriptures that have two values one with the reference and other with the scripture, and return the scripture of the reference. 
}
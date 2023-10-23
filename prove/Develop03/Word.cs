public class Word
{
    // private List<string> _words = new List<string>();
    private string _word;
    private bool _hidden;

    public Word()
    {

    }
    public Word(string word, bool hidden)
    {
        _word = word;
        _hidden = hidden;
    }
    
    public void SetText(string word)
    {
        _word = word;
    }
    public void SetHidden(bool hidden)
    {
        _hidden = hidden;
    }
    
    
    public string GetText()
    {
        return _word;
    }

    public bool GetHidden()
    {
        return _hidden;
    }

    // Parse the text into a list.
    public List<Word> ParseText(string text)
    {
        
        List<Word> words = new List<Word>();
        string[] wordsArray = text.Split(' ');

        foreach (string word in wordsArray)
        {
            words.Add(new Word(word, false));
        }

        return words;
        
    }




    // keep track of individual words.
}
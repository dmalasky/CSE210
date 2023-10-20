public class Word
{
    // private List<string> _words = new List<string>();
    private string _word;
    private bool _hidden;


    // public Word(List<string> words)
    // {
    //     _words = words;
    // }
    
    // Parse the text into a list.
    public List<string> ParseText(string text)
    {
        
        List<string> words = new List<string>();
        string[] wordsArray = text.Split(' ');

        foreach (string word in wordsArray)
        {
            words.Add(word);
        }

        return words;
        
    }

    // Display the 
    public void DisplayText(List<string> words)
    {
        
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }


    // keep track of individual words.
}
using System.Dynamic;
// Keep track of the scripture as a whole (ref + words)
public class Scripture
{
    // prop tab public with get set makes it private behind the scenes.
    public string Text { get; set; }

    public Scripture(string text)
    {
        Text = text;
    }

   
    // _text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledg him, and he shall direct thy paths.";
    


}
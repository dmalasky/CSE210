using System;

public class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;
    
    public MathAssignment(string textbookSection, string problems, string studentName, string topic) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHWList()
    {
        return $"{_textbookSection} {_problems}";
    }

}
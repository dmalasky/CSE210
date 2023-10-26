using System;

public class WritingAssignment : Assignment
{
    string _title;

    public WritingAssignment(string title, string studentName, string topic) : base(studentName, topic)
    {
        _title = title;
    }
    
    public string GetWritingInfo()
    {
        return $"{_title} by {_studentName}";
    }
}
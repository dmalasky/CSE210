using System;

public class Assignment
{
    protected string _studentName;
    string _topic;

    public Assignment()
    {

    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
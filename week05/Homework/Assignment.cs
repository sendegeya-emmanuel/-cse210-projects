using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Base constructor to initialize common attributes
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Public getter method to safely expose private data to child classes
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}
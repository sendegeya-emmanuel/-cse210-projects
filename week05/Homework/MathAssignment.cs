using System;

// Inherits from Assignment using the colon ':' operator
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor passes studentName and topic to the base constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return "Section " + _textbookSection + " Problems " + _problems;
    }
}
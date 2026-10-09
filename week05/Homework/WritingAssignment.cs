using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Accessing the private base variable using the public GetStudentName() getter
        return _title + " by " + GetStudentName();
    }
}
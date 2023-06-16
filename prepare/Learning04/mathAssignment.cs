using System;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment() {
        _textbookSection = "unknown";
        _problems = "unknown";
    }
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic) 
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList() {
        return $"{GetSummary()} \n{_textbookSection} - {_problems}";
    }
}
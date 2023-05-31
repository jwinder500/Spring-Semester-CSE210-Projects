public class WritingAssignment : Assignment
{
    private string title;
    public WritingAssignment(string Name, string Topic, string Title)
        : base(Name, Topic)
    {
        title = Title;
    }

    public string FindWritingInformation()
    {
        string Name = GetName();

        return $"{title} by {Name}";
    }
}
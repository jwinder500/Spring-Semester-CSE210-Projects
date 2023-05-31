public class Assignment
{
    private string Name;
    private string Topic;

    public Assignment(string name, string topic)
    {
        Name = name;
        Topic = topic;
    }
    public string GetName()
    {
        return Name;
    }

    public string GetTopic()
    {
        return Topic;
    }

    public string GetSummary()
    {
        return Name + " - " + Topic;
    }
}
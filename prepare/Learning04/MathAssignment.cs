public class MathAssignment : Assignment
{
    private string Section;
    private string Problems;
    public MathAssignment(string Name, string topic, string section, string problems)
        : base(Name, topic)
    {
        Section = section;
        Problems = problems;
    }

    public string GetHomework()
    {
        return $"Section {Section} Problems {Problems}";
    }
}
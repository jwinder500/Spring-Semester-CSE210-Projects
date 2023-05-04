using System;
public class Job
{
    public string _Company;
    public string _Title;
    public int _Start;
    public int _End;
    public void Show()
    {
        Console.WriteLine($"{_Title} {_Company} {_Start}-{_End}");
    }
}
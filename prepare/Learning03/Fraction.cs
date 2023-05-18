using System;

public class Fraction
{
    private int _over;
    private int _under;
    public Fraction()
    {
        _over = 1;
        _under = 1;
    }
    public Fraction(int Number)
    {
        _over = Number;
        _under = 1;
    }
    public Fraction(int top, int bottom)
    {
        _over = top;
        _under = bottom;
    }
    public string FractionString()
    {
        string fract = $"{_over}/{_under}";
        return fract;
    }
    public float Decimal()
    {
        return (float)_over / (float)_under;
    }
}
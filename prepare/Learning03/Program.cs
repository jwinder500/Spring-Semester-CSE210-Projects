using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine(f.FractionString());
        Console.WriteLine(f.Decimal());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.FractionString());
        Console.WriteLine(f2.Decimal());

        Fraction f3 = new Fraction(6, 8);
        Console.WriteLine(f3.FractionString());
        Console.WriteLine(f3.Decimal());

        Fraction f4 = new Fraction(2, 3);
        Console.WriteLine(f4.FractionString());
        Console.WriteLine(f4.Decimal());
    }
}
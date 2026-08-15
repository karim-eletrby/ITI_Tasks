using System;

public class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            Console.WriteLine("Denominator cannot be zero.");

        Numerator = numerator;
        Denominator = denominator;
    }

   
    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        int num = (f1.Numerator * f2.Denominator) + (f2.Numerator * f1.Denominator);
        int den = f1.Denominator * f2.Denominator;
        return new Fraction(num, den);
    }

    public static implicit operator Fraction(int value)
    {
        return new Fraction(value, 1);
    }

    public static explicit operator double(Fraction f)
    {
        return (double)f.Numerator / f.Denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
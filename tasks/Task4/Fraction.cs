using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Fraction
    {
        public double numerator;//why when this int
        public double denominator;

        public static void display(Fraction f1, Fraction f2)

        {
            double fraction1 = f1.numerator / f1.denominator;
            double fraction2 = f2.numerator / f2.denominator;
            Console.WriteLine($"fraction1={fraction1}");
            Console.WriteLine($"fraction2={fraction2}");

        }

        public static double SumFraction(Fraction f1, Fraction f2)
        {
            if (f1.numerator == 0 || f2.numerator == 0) Console.WriteLine("zero invaild in numenrator");
            else if (f1.denominator != f2.denominator)
            {
                double Fraction_Sum = (
                     (f1.numerator * f2.denominator) + (f2.numerator * f1.denominator))
                     / (f1.denominator * f2.denominator);
                return Fraction_Sum;
            }
            else
            {
                double Fraction_Sum = (
                     (f1.numerator * f2.numerator) / f1.denominator);
                return Fraction_Sum;

            }
            return -1;
        }
    }
}

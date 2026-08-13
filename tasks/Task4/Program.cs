using System.ComponentModel.DataAnnotations;

namespace Lab4
{
    class program
    {   /*------------------------TASK1--------------------*/
        static void Main()
        {
            point p1= new point();
            p1.x = 3.2;
            p1.y = 5.4;
            point p2= new point();
            p2.x = 13.2;
            p2.y = 10.4;
           point.display(p1);
           point.display(p2);
            //  point.Distance(p1, p2);

            double x, y;
            point.Distance(p1, p2, out x, out y);
            Console.WriteLine($"{x} and {y}");
            /*------------------------------------Task2----------------------------------------------*/
            Fraction f1= new Fraction();
            Fraction f2 = new Fraction();
            f1.numerator = 5;
            f1.denominator = 4;
            f2.numerator = 8;
            f2.denominator = 6;
            Fraction.display(f1, f2);
            Console.WriteLine( Fraction.SumFraction(f1, f2));

        }
    }
}
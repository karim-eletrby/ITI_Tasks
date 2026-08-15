using Task5_oop;

namespace task5
{
    class program
    {
        static void Main()
        {
            points p1 = new points(15.5, 10.20);
            points p2 = new points(51.6, 13.22);
            Console.WriteLine($"p1.x={p1.x}\np1.y={p1.y}\np2.x={p2.x}\np2.y={p2.y}");
            line l = new line(p1, p2);
            Console.WriteLine( l.getlength());
            Shape circle = new Circle(10);
            Shape rectangle  = new Rectangle(p1,p2);
            Shape square = new Square(p1,p2);
            Console.WriteLine($"circle area equal {circle.Calculate_Area()}");
            Console.WriteLine($"rectangle area eqaul {rectangle.Calculate_Area()}");
            Console.WriteLine($"Sqaure area eqaul {square.Calculate_Area()}");


        }
    }
}
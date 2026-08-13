using Task5_oop;

namespace task5
{
    class program
    {
        static void Main()
        {
            points p1 = new points(5.5, 3.2);
            points p2 = new points(5, 3.2);
            Console.WriteLine($"p1.x={p1.x}\np1.y={p1.y}\np2.x={p2.x}\np2.y={p2.y}");
            line l = new line(p1, p2);
            Console.WriteLine( l.getlength());
        }
    }
}
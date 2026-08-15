class Program
{
    static void Main()
    {
        Point3D P1 = new Point3D(10, 20, 30);
        Point3D P2 = new Point3D { X = 10, Y = 20, Z = 30 };

        Console.WriteLine($"P1: {P1}");
        Console.WriteLine($"P2: {P2}");

        Console.WriteLine($"P1 == P2: {P1 == P2}");         
        Console.WriteLine($"P1.Equals(P2): {P1.Equals(P2)}"); 
        Point3D[] points = new Point3D[]
        {
            P1,
            P2,
            new Point3D(5, 5, 5)
        };
        Point3D.Display(points);
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(1, 3);
        Fraction f3 = f1 + f2; 
        Console.WriteLine($"{f1} + {f2} = {f3}");
        Fraction fImplicit = 5;
        Console.WriteLine( fImplicit);

        double doubleVal = (double)f3; 
        Console.WriteLine(doubleVal);

        Address addr1 = new Address("domiat", "raselbar", "53661");
        Address addr2 = new Address("cairo", "madinty", "55300");

        Person[] people = new Person[]
        {
            new Employee("karim", 30, addr1, "2353153", 12000),
            new Trainee("osama", 22, addr2, "3010", 44),
            new Employee("ahmed", 35, addr1,"81234567", 18000)
        };

        foreach (Person person in people)
        {
            Console.WriteLine(person);
        }
    }
}
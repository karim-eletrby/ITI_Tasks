namespace task7
{
    class program
    {
        static void Main()
        {
            Employee E1 = new Employee("karim",roles.Admin,5000);
            Employee E2 = new Employee("mohamed", roles.None, 6000);
            Employee.Display_EmpData(E1);
            Employee.Display_EmpData(E2);
            E1.Assign_Role(roles.Accountant);
            Employee.Display_EmpData(E1);
            Console.WriteLine (E2.Has_Role());


        }
    }
}
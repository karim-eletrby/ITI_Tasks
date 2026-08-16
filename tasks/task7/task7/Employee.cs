using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    public  enum roles
    {   None,
        Admin,
        Accountant,
        Receptionist,
    }

    internal struct Employee
    {
        public Employee(string name, roles role, int salary)
        {
            this.EName = name;
            this.Role = role;
            this.salary = salary;
        }

        public string EName { get; set; }
        public   roles Role { get; set; }

        public int salary { get; set; }
        public  void Assign_Role(roles role)
        {
           this.Role = role;
        }
        public bool Has_Role()
        {
            if (Role !=  roles.None) return true;else return false;
        }
        public static void Display_EmpData(Employee e)
        {
            Console.WriteLine($"Employee Name:{e.EName}\n" +
                $"Employee Role:{e.Role}\n" +
                $"Employee Salary:{e.salary}");
        }
    }
}

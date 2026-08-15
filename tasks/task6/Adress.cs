using System;

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
    public string ZipCode { get; set; }

    public Address(string city, string street, string zipCode)
    {
        City = city;
        Street = street;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{Street}, {City} (Zip: {ZipCode})";
    }
}

public abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }

    public Person(string name, int age, Address address)
    {
        Name = name;
        Age = age;
        Address = address;
    }

    public abstract Person Clone();

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Address: [{Address}]";
    }
}

public class Employee : Person
{
    public string NID { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, int age, Address address, string nid, decimal salary)
        : base(name, age, address)
    {
        NID = nid;
        Salary = salary;
    }

    public override Person Clone()
    {
        Address clonedAddress = new Address(Address.City, Address.Street, Address.ZipCode);
        return new Employee(Name, Age, clonedAddress, NID, Salary);
    }

    public override string ToString()
    {
        return $"[Employee] {base.ToString()}, NID: {NID}, Salary: {Salary:C}";
    }
}

public class Trainee : Person
{
    public string NID { get; set; }
    public int IntakeNumber { get; set; }

    public Trainee(string name, int age, Address address, string nid, int intakeNumber)
        : base(name, age, address)
    {
        NID = nid;
        IntakeNumber = intakeNumber;
    }

    public override Person Clone()
    {
        Address clonedAddress = new Address(Address.City, Address.Street, Address.ZipCode);
        return new Trainee(Name, Age, clonedAddress, NID, IntakeNumber);
    }

    public override string ToString()
    {
        return $"[Trainee] {base.ToString()}, NID: {NID}, Intake: {IntakeNumber}";
    }
}
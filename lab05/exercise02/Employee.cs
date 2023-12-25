using System;

public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Salary: {Salary:C}");
    }
}

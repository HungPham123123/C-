using System;

class Employee
{
    // Instance variables
    private string firstName;
    private string lastName;
    private string address;
    private long sin;
    private double salary;

    // Constructor
    public Employee(string firstName, string lastName, string address, long sin, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.sin = sin;
        this.salary = salary;
    }

    // Method to calculate bonus
    public double CalculateBonus(double percentage)
    {
        return salary * (percentage / 100);
    }

    // ToString method override
    public override string ToString()
    {
        return $"Employee Information:\nName: {firstName} {lastName}\nAddress: {address}\nSIN: {sin}\nSalary: ${salary:F2}";
    }
}

class Program
{
    static void Main()
    {
        // Test the Employee class
        Employee employee = new Employee("John", "Doe", "123 Main St", 123456789, 50000);

        // Print employee information
        Console.WriteLine(employee);

        // Test bonus calculation
        double bonusPercentage = 10;
        double bonusAmount = employee.CalculateBonus(bonusPercentage);
        Console.WriteLine($"Bonus: ${bonusAmount:F2} ( {bonusPercentage}% of salary )");
    }
}

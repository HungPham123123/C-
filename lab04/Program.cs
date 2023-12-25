using System;

class Person
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }

    public Person(string name, string phoneNumber, string emailAddress)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
    }

    public override string ToString()
    {
        return $"{GetType().Name} - Name: {Name}, Email: {EmailAddress}";
    }
}

class Student : Person
{
    public string Program { get; set; }

    public Student(string name, string phoneNumber, string emailAddress, string program)
        : base(name, phoneNumber, emailAddress)
    {
        Program = program;
    }
}

abstract class Employee : Person
{
    public string Department { get; set; }
    public double Salary { get; set; }
    public DateTime DateHired { get; set; }

    public Employee(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHired)
        : base(name, phoneNumber, emailAddress)
    {
        Department = department;
        Salary = salary;
        DateHired = dateHired;
    }

    public abstract double CalculateBonus();
    public abstract int CalculateVacation();
}

class Faculty : Employee
{
    public string OfficeHours { get; set; }
    public string Rank { get; set; }

    public Faculty(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHired, string officeHours, string rank)
        : base(name, phoneNumber, emailAddress, department, salary, dateHired)
    {
        OfficeHours = officeHours;
        Rank = rank;
    }

    public override double CalculateBonus()
    {
        return 1000 + 0.05 * Salary;
    }

    public override int CalculateVacation()
    {
        int baseVacation = DateHired.Year <= DateTime.Now.Year - 3 ? 5 : 4;
        return Rank == "Senior Lecturer" ? baseVacation + 1 : baseVacation;
    }
}

class Staff : Employee
{
    public string Title { get; set; }

    public Staff(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHired, string title)
        : base(name, phoneNumber, emailAddress, department, salary, dateHired)
    {
        Title = title;
    }

    public override double CalculateBonus()
    {
        return 0.06 * Salary;
    }

    public override int CalculateVacation()
    {
        return DateHired.Year <= DateTime.Now.Year - 5 ? 4 : 3;
    }
}

class Program
{
    private static Student student;
    private static Faculty faculty;
    private static Staff staff;

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("1. Create and Display Student");
            Console.WriteLine("2. Create and Display Faculty");
            Console.WriteLine("3. Create and Display Staff");
            Console.WriteLine("4. Display Student Information");
            Console.WriteLine("5. Display Faculty Information");
            Console.WriteLine("6. Display Staff Information");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option (1-7): ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateAndDisplayStudent();
                    break;
                case 2:
                    CreateAndDisplayFaculty();
                    break;
                case 3:
                    CreateAndDisplayStaff();
                    break;
                case 4:
                    DisplayStudentInformation();
                    break;
                case 5:
                    DisplayFacultyInformation();
                    break;
                case 6:
                    DisplayStaffInformation();
                    break;
                case 7:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 7);
    }

    static void CreateAndDisplayStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter email address: ");
        string emailAddress = Console.ReadLine();
        Console.Write("Enter program: ");
        string program = Console.ReadLine();

        student = new Student(name, phoneNumber, emailAddress, program);
        Console.WriteLine(student.ToString());
        Console.WriteLine("Result displayed successfully.");
    }

    static void CreateAndDisplayFaculty()
    {
        Console.Write("Enter faculty name: ");
        string name = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter email address: ");
        string emailAddress = Console.ReadLine();
        Console.Write("Enter department: ");
        string department = Console.ReadLine();
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.Write("Enter date hired (yyyy-mm-dd): ");
        DateTime dateHired = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter office hours: ");
        string officeHours = Console.ReadLine();
        Console.Write("Enter rank: ");
        string rank = Console.ReadLine();

        faculty = new Faculty(name, phoneNumber, emailAddress, department, salary, dateHired, officeHours, rank);
        Console.WriteLine(faculty.ToString());
        Console.WriteLine($"Bonus: {faculty.CalculateBonus()}, Vacation: {faculty.CalculateVacation()} weeks");
        Console.WriteLine("Result displayed successfully.");
    }

    static void CreateAndDisplayStaff()
    {
        Console.Write("Enter staff name: ");
        string name = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter email address: ");
        string emailAddress = Console.ReadLine();
        Console.Write("Enter department: ");
        string department = Console.ReadLine();
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.Write("Enter date hired (yyyy-mm-dd): ");
        DateTime dateHired = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter title: ");
        string title = Console.ReadLine();

        staff = new Staff(name, phoneNumber, emailAddress, department, salary, dateHired, title);
        Console.WriteLine(staff.ToString());
        Console.WriteLine($"Bonus: {staff.CalculateBonus()}, Vacation: {staff.CalculateVacation()} weeks");
        Console.WriteLine("Result displayed successfully.");
    }

    static void DisplayStudentInformation()
    {
        if (student != null)
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine(student.ToString());
        }
        else
        {
            Console.WriteLine("No student information available.");
        }
    }

    static void DisplayFacultyInformation()
    {
        if (faculty != null)
        {
            Console.WriteLine("Faculty Information:");
            Console.WriteLine(faculty.ToString());
            Console.WriteLine($"Bonus: {faculty.CalculateBonus()}, Vacation: {faculty.CalculateVacation()} weeks");
        }
        else
        {
            Console.WriteLine("No faculty information available.");
        }
    }

    static void DisplayStaffInformation()
    {
        if (staff != null)
        {
            Console.WriteLine("Staff Information:");
            Console.WriteLine(staff.ToString());
            Console.WriteLine($"Bonus: {staff.CalculateBonus()}, Vacation: {staff.CalculateVacation()} weeks");
        }
        else
        {
            Console.WriteLine("No staff information available.");
        }
    }
}

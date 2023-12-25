using System;

class Program
{
    static void Main()
    {
        try
        {
            bool exit = false;

            do
            {
                Console.WriteLine("1. Display Employee Details");
                Console.WriteLine("2. Check Senior Lecturer's Salary");
                Console.WriteLine("3. Check Senior Lecturer's Bonus");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayEmployeeDetails();
                        break;
                    case "2":
                        CheckSeniorLecturerSalary();
                        break;
                    case "3":
                        CheckSeniorLecturerBonus();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (!exit);
        }
        catch (AmountException ex)
        {
            Console.WriteLine($"AmountException: {ex.Message}. Person: {ex.PersonName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }

    static void DisplayEmployeeDetails()
    {
        Employee employee1 = new Employee { Name = "John Doe", Salary = 60000 };
        Employee employee2 = new SeniorLecturer { Name = "Jane Smith", Salary = 70000, Bonus = 5000 };

        Console.WriteLine("Employee 1 Details:");
        DisplayEmployeeDetails(employee1);

        Console.WriteLine("\nEmployee 2 Details:");
        DisplayEmployeeDetails(employee2);
    }

    static void CheckSeniorLecturerSalary()
    {
        Console.Write("Enter Senior Lecturer's salary: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        SeniorLecturer seniorLecturer = new SeniorLecturer { Name = "Test Senior Lecturer", Salary = salary };
        CheckSalary(seniorLecturer);
    }

    static void CheckSeniorLecturerBonus()
    {
        Console.Write("Enter Senior Lecturer's bonus: ");
        decimal bonus = Convert.ToDecimal(Console.ReadLine());

        SeniorLecturer seniorLecturer = new SeniorLecturer { Name = "Test Senior Lecturer", Bonus = bonus };
        CheckBonus(seniorLecturer);
    }

    static void DisplayEmployeeDetails(Employee employee)
    {
        employee.DisplayDetails();
    }

    static void CheckSalary(Employee employee)
    {
        if (employee is SeniorLecturer seniorLecturer && seniorLecturer.Salary < 60000)
        {
            throw new AmountException(employee.Name, "Senior Lecturer's salary is less than 60,000.");
        }
        else
        {
            Console.WriteLine("Salary check passed.");
        }
    }

    static void CheckBonus(SeniorLecturer seniorLecturer)
    {
        if (seniorLecturer.Bonus > 10000)
        {
            throw new AmountException(seniorLecturer.Name, "Bonus amount exceeds 10,000.");
        }
        else
        {
            Console.WriteLine("Bonus check passed.");
        }
    }
}

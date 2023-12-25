using System;

public class SeniorLecturer : Employee
{
    public decimal Bonus { get; set; }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Bonus: {Bonus:C}");
    }
}

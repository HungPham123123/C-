using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number between 1 and 7: ");

        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput))
        {
            if (userInput >= 1 && userInput <= 7)
            {
                string dayOfWeek = GetDayOfWeek(userInput);

                Console.WriteLine($" {userInput} is {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.ReadKey();
    }

    static string GetDayOfWeek(int dayNumber)
    {
        switch (dayNumber)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
            default:
                return "Invalid day";
        }
    }
}

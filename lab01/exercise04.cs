using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");

        if (int.TryParse(Console.ReadLine(), out int N))
        {
            Console.WriteLine($"The first 9 multiples of {N} are:");

            for (int i = 1; i <= 9; i++)
            {
                int multiple = N * i;
                Console.WriteLine($"{N} x {i} = {multiple}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.ReadKey();
    }
}

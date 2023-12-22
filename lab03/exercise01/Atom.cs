using System;

public class Atom
{
    private int atomicNumber;
    private string symbol;
    private string fullName;
    private double atomicWeight;

    public bool Accept()
    {
        Console.Write("Enter atomic number: ");
        if (!int.TryParse(Console.ReadLine(), out atomicNumber) || atomicNumber <= 0)
        {
            Console.WriteLine("Invalid input for atomic number. Please enter a positive integer.");
            return false;
        }

        Console.Write("Enter symbol: ");
        symbol = Console.ReadLine();

        Console.Write("Enter full name: ");
        fullName = Console.ReadLine();

        Console.Write("Enter atomic weight: ");
        if (!double.TryParse(Console.ReadLine(), out atomicWeight) || atomicWeight <= 0)
        {
            Console.WriteLine("Invalid input for atomic weight. Please enter a positive floating-point number.");
            return false;
        }

        return true;
    }

    public void Display()
    {
        Console.WriteLine($"{atomicNumber,-4} {symbol,-3} {fullName,-10} {atomicWeight,-8:F3}");
    }
}

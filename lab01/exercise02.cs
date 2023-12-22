using System;

class Program
{
    static void Main()
    {
        int num1 = 42;
        int num2 = 17;
        int num3 = 29;

        int maxNumber = FindMax(num1, num2, num3);

        Console.WriteLine($"The maximum number among {num1}, {num2}, and {num3} is: {maxNumber}");

        Console.ReadKey();
    }

    static int FindMax(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }
}
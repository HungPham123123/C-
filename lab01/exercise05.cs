using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Factorials of the integers from 1 to 20:");

        for (int i = 1; i <= 20; i++)
        {
            BigInteger factorial = CalculateFactorial(i);
            Console.WriteLine($"Factorial of {i}: {factorial}");
        }

        Console.ReadKey();
    }

    static BigInteger CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}

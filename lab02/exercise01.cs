using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("SIN Validator");
        Console.WriteLine("===============");

        while (true)
        {
            Console.Write("SIN (0 to quit): ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("Have a Nice Day!");
                break;
            }

            if (IsValidSIN(input))
            {
                Console.WriteLine("This is a valid SIN.");
            }
            else
            {
                Console.WriteLine("This is not a valid SIN.");
            }
        }
    }

    static bool IsValidSIN(string input)
    {
        string[] sinDigits = input.Split(' ');

        int[] sinIntArray = new int[sinDigits.Length];

        for (int i = 0; i < sinDigits.Length; i++)
        {
            sinIntArray[i] = int.Parse(sinDigits[i]);
        }

        int sumEvenPositioned = 0;
        int sumOddPositioned = 0;

        for (int i = 0; i < sinIntArray.Length - 1; i++)
        {
            if (i % 2 == 0)
            {
                int doubledDigit = sinIntArray[i] * 2;
                sumEvenPositioned += doubledDigit % 10 + doubledDigit / 10;
            }
            else
            {
                sumOddPositioned += sinIntArray[i];
            }
        }

        int totalSum = sumEvenPositioned + sumOddPositioned;
        int checkDigit = (totalSum % 10 == 0) ? 0 : 10 - (totalSum % 10);

        return checkDigit == sinIntArray[sinIntArray.Length - 1];
    }
}

using System;

class lab01ex1
{
    static void Main()
    {
        string name = "";
        string address = "";
        string phone = "";

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create Information");
            Console.WriteLine("2. Show Information");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();

                    Console.Write("Enter your address: ");
                    address = Console.ReadLine();

                    Console.Write("Enter your phone number: ");
                    phone = Console.ReadLine();
                    break;

                case "2":

                    Console.WriteLine("\nEntered Information:");
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Address: {address}");
                    Console.WriteLine($"Phone Number: {phone}");
                    break;

                case "3":

                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}

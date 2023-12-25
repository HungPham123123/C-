using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Order Grocery Items");
        Console.WriteLine("2. Order Bakery Products");

        int choice = int.Parse(Console.ReadLine());

        Customer.CustomerService customerService = new Customer.CustomerService();
        customerService.AcceptCustomerName(customerName);

        switch (choice)
        {
            case 1:
                Order.GroceryOrder groceryOrder = new Order.GroceryOrder();
                groceryOrder.ProcessGroceryOrder(customerName);
                break;

            case 2:
                Order.BakeryOrder bakeryOrder = new Order.BakeryOrder();
                bakeryOrder.ProcessBakeryOrder(customerName);
                break;

            default:
                Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                break;
        }
    }
}

using System;

namespace Customer
{
    public class CustomerService
    {
        public void AcceptCustomerName(string customerName)
        {
            Console.WriteLine($"Welcome, {customerName}! How can we assist you today?");
        }
    }
}

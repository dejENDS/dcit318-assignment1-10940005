// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter their age
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        // Define ticket prices
        decimal standardPrice = 10.0m;
        decimal discountedPrice = 7.0m;

        // Determine the ticket price based on age
        decimal ticketPrice;
        if (age >= 65 || age <= 12)
        {
            ticketPrice = discountedPrice;
        }
        else
        {
            ticketPrice = standardPrice;
        }

        // Display the ticket price to the user
        Console.WriteLine($"Ticket price: GHC{ticketPrice}");
    }
}

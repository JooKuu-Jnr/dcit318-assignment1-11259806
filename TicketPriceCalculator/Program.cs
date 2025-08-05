using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to JooKuu's Assignment.");
        Console.WriteLine("Enter your age:");

        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int age))
        {
            if (age >= 65 || age <= 12)
            {
                Console.WriteLine("Ticket Price: GHC 7");
            }
            else
            {
                Console.WriteLine("Ticket Price: GHC 10");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid age.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ticket Booking System!");

            while (true)
            {
                // Display ticket options
                Console.WriteLine("Ticket Options:");
                Console.WriteLine("1. Silver");
                Console.WriteLine("2. Gold");
                Console.WriteLine("3. Diamond");
                Console.WriteLine("Type 'Exit' to quit");

                // Take user input for ticket type
                Console.Write("Enter the ticket type (1 for Silver, 2 for Gold, 3 for Diamond, or 'Exit' to quit): ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the Ticket Booking System.");
                    break;
                }

                int ticketType = Convert.ToInt32(userInput);

                string ticketTypeName = "";
                double baseTicketPrice = 0;

                // Assign ticket type and base price based on user input
                switch (ticketType)
                {
                    case 1:
                        ticketTypeName = "Silver";
                        baseTicketPrice = 50.0; // Set base price for Silver tickets
                        break;
                    case 2:
                        ticketTypeName = "Gold";
                        baseTicketPrice = 100.0; // Set base price for Gold tickets
                        break;
                    case 3:
                        ticketTypeName = "Diamond";
                        baseTicketPrice = 150.0; // Set base price for Diamond tickets
                        break;
                    default:
                        Console.WriteLine("Invalid ticket type selected.");
                        continue;
                }

                // Take user input for number of tickets needed
                Console.Write($"Enter the number of {ticketTypeName} tickets needed: ");
                int numOfTickets = Convert.ToInt32(Console.ReadLine());

                // Calculate total cost of tickets booked
                double totalCost = baseTicketPrice * numOfTickets;

                // Display total cost of tickets booked
                Console.WriteLine($"Total cost for {numOfTickets} {ticketTypeName} tickets: ${totalCost}");
            }
        }
    }
}

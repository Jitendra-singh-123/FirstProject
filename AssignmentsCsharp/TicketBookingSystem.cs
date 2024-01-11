using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    class TicketBookingSystem
    {
        //Task1
        static void Main() {
            int availableTicket, noOfBookingTicket;
            Console.WriteLine("Enter number of available tickets: ");
            availableTicket = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of booking tickets: ");
            noOfBookingTicket = int.Parse(Console.ReadLine());

            if (availableTicket >= noOfBookingTicket)
            {
                int remainingTickets = availableTicket - noOfBookingTicket;
                Console.WriteLine($"Tickets booked successfully! Remaining tickets: {remainingTickets}");
            }
            else
            {
                Console.WriteLine("Tickets are unavailable. Not enough tickets to book.");
            }
            Console.ReadLine();
        }
    }
}

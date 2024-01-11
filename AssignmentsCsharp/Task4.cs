using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    public enum EventType { 
        Movie,
        Sports,
        Concert
    }
   public class Event {
        public string event_name { get; set; }
        public DateTime event_date { get; set; }
        public TimeSpan event_time { get; set; }
        public string venue_name { get; set; }
        public int total_seats { get; set; }
        public int available_seats { get; set; }
        public double ticket_price { get; set; }
        public EventType event_type { get; set; }

        public Event(string event_name, DateTime event_date,TimeSpan event_time,string venue_name,int total_seats,int available_seats, double ticket_price,EventType event_type){
            this.event_name = event_name;
            this.event_date = event_date;
            this.event_time = event_time;
            this.venue_name = venue_name;
            this.total_seats = total_seats;
            this.available_seats = available_seats;
            this.ticket_price = ticket_price;
            this.event_type = event_type;
        }
        public void Calculate_total_revenue(int num_tickets ) {
            double total_revenue = num_tickets * ticket_price;
            Console.WriteLine($"Total Revenue: ${total_revenue}");
        }
        public int getBookedNoOfTickets() {
            return total_seats - available_seats;
        }
        public void book_tickets(int num_tickets) {
            if (available_seats >= num_tickets)
            {
                available_seats -= num_tickets;
                Console.WriteLine($"Successfully booked {num_tickets} tickets for the event.");
            }
            else
            {
                Console.WriteLine("Not enough available seats to book this many tickets.");
            }
        }
        public void cancel_booking(int num_tickets) {
            available_seats += num_tickets;
            Console.WriteLine($"Cancelled booking for {num_tickets} tickets.");

        }
       public void display_event_details() {
            Console.WriteLine($"Event Name: {event_name}");
            Console.WriteLine($"Event Date: {event_date.ToShortDateString()}");
            Console.WriteLine($"Event Time: {event_time.ToString()}");
            Console.WriteLine($"Venue: {venue_name}");
            Console.WriteLine($"Total Seats: {total_seats}");
            Console.WriteLine($"Available Seats: {available_seats}");
            Console.WriteLine($"Ticket Price: ${ticket_price}");
            Console.WriteLine($"Event Type: {event_type}");
        }
    }
    class Venue
    {
        public string venue_name { get; set; }
        public string address { get; set; }
        public Venue(string venue_name, string address)
        {
            this.venue_name = venue_name;
            this.address = address;
        }
        public void display_venue_details()
        {
            Console.WriteLine($"Venue Name : ${venue_name}");
            Console.WriteLine($"Address : ${address}");
        }
    }

    class Customer
    {
        public string customer_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
       public Customer(string customer_name, string email,string phone_number) {
            this.customer_name = customer_name;
            this.email = email;
            this.phone_number = phone_number;
        }
        public void display_customer_details() {
            Console.WriteLine($"Customer Name: {customer_name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone Number: {phone_number}");
        }

    }

    class Booking {
        public void calculate_booking_cost(Event obj, int num_tickets) {
            double total_cost = obj.ticket_price * num_tickets;
            Console.WriteLine($"Total cost of booking: ${total_cost}");
        }
        public void book_tickets(Event obj, int num_tickets)
        {
            obj.book_tickets(num_tickets);
        }
        public void cancel_booking(Event eventObj, int num_tickets)
        {
            eventObj.cancel_booking(num_tickets);
        }

        public int getAvailableNoOfTickets(Event eventObj)
        {
            return eventObj.available_seats;
        }

        public Event getEventDetails(Event eventObj)
        {
            return eventObj;
        }

    }
    class Task4
    {
        static void Main() {
            Event eventObj = new Event("Rock Concert", DateTime.Now.Date, DateTime.Now.TimeOfDay,
                                   "Delhi", 100, 100, 25.2, EventType.Concert);

            Venue venueObj = new Venue("Concert Hall C", "123,near St. Thomas");

            Customer customerObj = new Customer("John Doe", "john@example.com", "123-456-7890");
            Booking bookingObj = new Booking();

            eventObj.display_event_details();
            venueObj.display_venue_details();
            customerObj.display_customer_details();
            Console.WriteLine();

            bookingObj.calculate_booking_cost(eventObj, 3);
            bookingObj.book_tickets(eventObj, 2);
            bookingObj.cancel_booking(eventObj, 1);

            int availableTickets = bookingObj.getAvailableNoOfTickets(eventObj);
            Console.WriteLine($"Available Tickets: {availableTickets}");

            Event eventDetails = bookingObj.getEventDetails(eventObj);
            eventDetails.display_event_details();

            Console.ReadLine();
        }
    }
}

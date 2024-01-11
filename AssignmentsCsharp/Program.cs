using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    class Bike {
        public string Model;
        public string Color;
        public int Year;
        public int Price;
        public void AcceptingDetails(string Model,string Color, int Year, int Price) {
            this.Model = Model;
            this.Color = Color;
            this.Year = Year;
            this.Price = Price;
            Console.WriteLine("Accepting the Bike details");
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Displaying Bike Details");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: {Price}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Bike b = new Bike();
            Console.Write("Enter Bike price: ");
            int price = int.Parse(Console.ReadLine());

            Console.Write("Enter Bike Model: ");
            string model = Console.ReadLine();

            Console.Write("Enter Bike Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter Bike Color: ");
            string color = Console.ReadLine();

            b.AcceptingDetails(model,color,year,price);
            b.DisplayDetails();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    class AssignmentTraineer2_cs
    {
        public static void Main() {
            Console.WriteLine("Enter Unit Consumed: ");
            int unit = int.Parse(Console.ReadLine());
            double bill =0  ;
            if (unit >= 1 && unit <= 100)
            {
                Console.WriteLine($"Bill Amount : {bill}  Your Bill is free");
            }
            else if (unit >= 101 && unit <= 250)
            {
                bill = unit * 8;
                Console.WriteLine($"Bill Amount : {bill}");
            }
            else if (unit >= 250 && unit <= 500)
            {
                Console.WriteLine($"Bill Amount : {bill}");
                bill = unit * 15;
            }
            
            Console.ReadLine();
        }
    }
}

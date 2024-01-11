using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    class AssignmentTraineer1
    {
        static void Main() {
            string name;
            int roll_number;
            int marks;
            Console.WriteLine("Enter name of student");
            name = Console.ReadLine();
            Console.WriteLine("Enter Roll number of student");
            roll_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of all subject");
            int SumOfMarks = 0;
            for (int i = 0; i < 5; i++) {
                marks = int.Parse(Console.ReadLine());
                SumOfMarks += marks;
            }
            double percentage = SumOfMarks / 5;

            if (percentage >= 95 && percentage <= 100)
                Console.WriteLine("Excellent");
            else if (percentage >= 90 && percentage <= 95)
                Console.WriteLine("Very Good");
            else if (percentage >= 85 && percentage <= 90)
                Console.WriteLine("Good");
            else if (percentage >= 80 && percentage <= 85)
                Console.WriteLine("Fair");
            else if (percentage >= 75 && percentage <= 80)
                Console.WriteLine("Passed");
            else
                Console.WriteLine("Failed");
            Console.ReadLine();


        }
    }
}

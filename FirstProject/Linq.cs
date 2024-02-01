using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Linq
    {
        static void Main()
        {
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Average of array elements: " + numbers.Average());

            //var oddNumbers = numbers.Where(n=>n%2==1);
            //var evenNumbers = numbers.Where(n=>n%2==0);

            //Console.WriteLine("Odd Numbers are: ");
            //foreach (int  item in oddNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("even Numbers are: ");
            //foreach (int item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            int nos;
            Console.WriteLine("Enter Number of Students");
            nos = int.Parse(Console.ReadLine());
            string[] students = new string[nos];
            Console.WriteLine($"Enter Students {nos} Names ");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter Students {i+1}\'s Name");
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("Stored Names are: ");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("Enter character/characters to search names from Array");
            string searchValue = Console.ReadLine();
           // var searchResult = from resStudent in students where resStudent.Contains(searchValue) select resStudent;
            var searchResult  = students.Where(resStudent => resStudent.Contains(searchValue));

            if (searchResult.Count() > 0)
            {
                Console.WriteLine("Student List as follows");
                foreach (var item in searchResult)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No such student exists");
            }
            Console.ReadKey();  
        }
    }
}

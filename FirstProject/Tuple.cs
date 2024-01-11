using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FirstProject
{
    class Tuple
    {
        static void Main()
        {
            //var numbers = System.Tuple.Create(1, "Hello");
            //Console.WriteLine(numbers.Item1);
            //var persons = System.Tuple.Create(101, "Yash", "Student");
            //Console.WriteLine(persons.Item1 + "\n" + persons.Item2);
           // var My_Tuple = System.Tuple.Create(13, System.Tuple.Create(12, 30, 40,
                              // 50), 67, 89.90, 'g', 39939, 123, "geeks");
            //Console.WriteLine(My_Tuple.Item3);
            //Console.WriteLine(My_Tuple.Item2.Item1);

            //Tuple as method parameter
            var empTuple = System.Tuple.Create(101, "Geetha", "Delhi");
            DisplayTupleInfo(empTuple);

            //Tuple as return type
            
            Console.ReadLine();

        }
        static void DisplayTupleInfo(Tuple<int,string,string> employee)
        {
            Console.WriteLine($"EmployeeID = {employee.Item1}\nName = {employee.Item2}\nLocation = {employee.Item3}");
        }
    }
}

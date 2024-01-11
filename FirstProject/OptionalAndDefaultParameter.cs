using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace FirstProject
{
    class OptionalAndDefaultParameter
    {
        //Optional Parameter with default values
        static void GetEmployeeDetails(int id,string name,string location = "Hyderabad", int salary=35000)
        {
            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"Id = {id}\n Name = {name}");
            Console.WriteLine($"Location = {location}\n Salary = {salary}\n ");

        }
        //Optional Parameter
        static void PrintEmployeeDetails(int id, string name, string location ,[Optional]int salary )
        {
            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"Id = {id}\n Name = {name}");
            Console.WriteLine($"Location = {location}\n Salary = {salary}\n ");

        }
        static void Main()
        {
            GetEmployeeDetails(101, "Rahul", "Delhi");
            GetEmployeeDetails(102, "Karan");
            GetEmployeeDetails(103, "Jay", "Mumbai",45000);
          

            PrintEmployeeDetails(104, "K. Menon","Delhi");
            PrintEmployeeDetails(105, "R. Rathore","Mumbai",9000);

            //Named Parameter
            GetEmployeeDetails(name: "Lalitha", id: 107, location: "Chennai");

            Console.ReadLine();
        }
    }
}

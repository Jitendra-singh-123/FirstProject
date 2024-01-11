using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
//    Rules for Static Class
//Static classes cannot be instantiated.
//All the members of a static class must be static; otherwise the compiler will give an error.
//A static class can contain static variables, static methods, static properties, static operators, static events, and static constructors.
//A static class cannot contain instance members and constructors.
//Indexers and destructors cannot be static
//var cannot be used to define static members.You must specify a type of member explicitly after the static keyword.
//Static classes are sealed class and therefore, cannot be inherited.
//A static class cannot inherit from other classes.
//Static class members can be accessed using ClassName.MemberName.
//A static class remains in memory for the lifetime of the application domain in which your program resides.
    static class Employee1
    {
        static int id;
        static string name;
        // int eid; //error as it is non-static
        //string ename;
        //public void GetEmployeeDetails()
        //{
        //    Console.WriteLine("Enter the employeeid and name");
        //    id = int.Parse(Console.ReadLine());
        //    name = Console.ReadLine();
        //}

        public static void GetEmployeeDetails()
        {
           // Employee1 emp = new Employee();
            Console.WriteLine("Employee details are:  ");
            Console.WriteLine($"Id = {id} \n Name = {name}");
            
        }
    }
    class StaticClass
    {   
        static void Main() {
            Employee1.GetEmployeeDetails();
            Console.ReadLine();
        }
    }
}

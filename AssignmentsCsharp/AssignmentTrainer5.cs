using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    class Employee
    {
        public int Id
        {
            get;
            set;
        }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        
        public Employee(int id, string name, string designation, double salary)
        {
            Id = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }
        public virtual double Bonus()
        {
            return 0;
        }

    }
    class Developer: Employee
    {
        public Developer(int id, string name, string designation, double salary):base(id,name,designation,salary)
        {

        }
        public override double Bonus()
        {
            return Salary * 0.2;
        }

    }
    class Trainee: Employee
    {
        public Trainee(int id, string name, string designation, double salary) : base(id, name, designation, salary)
        {

        }
        public override double Bonus()
        {
            return Salary * 0.05;
        }
    }
    class Manager: Employee
    {
        public Manager(int id, string name, string designation, double salary) : base(id, name, designation, salary)
        {

        }
        public override double Bonus()
        {
            return Salary * 0.25;
        }
    }
    class Admin: Employee
    {
        public Admin(int id, string name, string designation, double salary) : base(id, name, designation, salary)
        {

        }
        public override double Bonus()
        {
            return Salary * 0.1;
        }
    }

    class AssignmentTrainer5
    {
        static void Main()
        {
            Employee e = new Employee(1,"Rahul","Employee",120000);
            Console.WriteLine($"Bonus for Employee {e.Name} : {e.Bonus()}");

            Developer d = new Developer(121, "Jay", "Developer", 300000);
            Console.WriteLine($"Bonus for Developer {d.Name} : {d.Bonus()}");

            Trainee t = new Trainee(200, "John", "Trainee", 12000);
            Console.WriteLine($"Bonus for Trainee {t.Name} : {t.Bonus()}");

            Manager m = new Manager(300,"Jk Menon", "Manager", 9000000);
            Console.WriteLine($"Bonus for Manager {m.Name} : {m.Bonus()}");

            Admin a = new Admin(400, "K. Tripathi", "Admin", 700000);
            Console.WriteLine($"Bonus for Admin {a.Name} : {a.Bonus()}");

            Console.ReadLine();



        }
    }
}

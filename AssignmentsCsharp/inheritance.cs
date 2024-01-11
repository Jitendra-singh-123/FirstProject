using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    class employee {
        public int id;
        public string name;
        public decimal salary;
        public DateTime DOB;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public DateTime Dob
        {
            get { return DOB; }
            set { DOB = value; }
        }
        public virtual decimal ComputeSalary()
        {
            // Basic implementation for employee salary
            return salary;
        }
    }
    class manager: employee
    { 
        public decimal onsiteallowance;
        public decimal bonus;
        public decimal OnsiteAllowance
        {
            get { return onsiteallowance; }
            set { onsiteallowance = value; }
        }
        public decimal Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public override decimal ComputeSalary() {
            return salary + onsiteallowance + bonus;
        }
    }
    class inheritance
    {
        static void Main() {
            employee e = new employee();
            e.Id = 101;
            e.Name = "John";
            e.salary = 12100;
            e.Dob = new DateTime(1989, 6, 18);
            Console.WriteLine($"Employee ID: {e.Id}");
            Console.WriteLine($"Employee Name: {e.Name}");
            Console.WriteLine($"Employee Salary: {e.Salary}");
            Console.WriteLine($"Employee Date of Birth: {e.Dob}");

            Console.ReadLine();
        }
    }
}

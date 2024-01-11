using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Employee : IComparable<Employee>
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public int CompareTo(Employee other)
        {
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }
    }

    class CompareEmployee : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.CustId > y.CustId)
                return 1;
            else if (x.CustId < y.CustId)
                return -1;
            else
                return 0;

        }
    }
    class IComparableInterface
    {
        static void Main() {
            //In case of generic collection the type of values we want to store under the collections need not to be pre-defined typed only
            //like int, float,chaar, string,bool etc., but it can also be some user-defined type also.

            List<Employee> l = new List<Employee>();
            Employee e1 = new Employee { CustId = 121, Name = "Joe", Salary = 12000.234, Department = "Database Administrator" };
            Employee e2 = new Employee { CustId = 122, Name = "Rock", Salary = 220000, Department = "Software Engineer" };
            Employee e3 = new Employee { CustId = 123, Name = "John", Salary = 500000, Department = "Data Scientist" };
            Employee e4 = new Employee { CustId = 120, Name = "Chritain", Salary = 98800, Department = "Editor" };

            //storing the Customer Instances in List l
            l.Add(e1); l.Add(e2); l.Add(e3); l.Add(e4);

            var filteredEmployees = l.Where(emp => emp.Salary > 200000).ToList();

            foreach(Employee emp in filteredEmployees)
            {
                Console.WriteLine($"{emp.CustId}\t {emp.Name}\t {emp.Salary}");
            }
            //get CT error as we are not mentioning  on what basis we need to sort,
            //l.Sort();

            //to sort we need to implement IComparable Interface in Employee and implement CompareTo method on Employee class
            // l.Sort();
            // l.Reverse();
            //sometime we don't have access for the Emplpyee class, so we don't know what is  the implementation in Employee class and how to sort
            //for that we define our own class like here CompareEmployee and will implement IComparer interface
            CompareEmployee obj1 = new CompareEmployee();
            // l.Sort();//sorting on the basis of Salary

            //Overriding sort
            l.Sort(obj1); //Sorting on the basis of CustId




            foreach (Employee obj in l)
            {
                Console.WriteLine(obj.CustId + " " + obj.Name + " " + obj.Salary + " " + obj.Department);
            }
            Console.ReadLine();
        }
    }
}

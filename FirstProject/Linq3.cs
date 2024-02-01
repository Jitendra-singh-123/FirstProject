using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Person
    {

        public string Name { get; set; }
        public string Profession { get; set; }
        public DateTime DOJ { get; set; }
        public double Salary { get; set; }
        
    }
    class Linq3
    {
        public static void Main()
        {
            List<Person> personsList = new List<Person>()
            {
                new Person{Name = "Rahul",DOJ = new DateTime(2023,01,14),Salary = 45000,Profession = "Developer"},
                new Person{Name = "K menon",DOJ = new DateTime(2024,01,18),Salary = 41000,Profession = "Tester"},
                new Person{Name = "Mohit",DOJ = new DateTime(2018,08,20),Salary = 69000,Profession = "HR"},
                new Person{Name = "Ashish",DOJ = new DateTime(2019,07,24),Salary = 75000,Profession = "Manager"},
                new Person{Name = "Jk Singh",DOJ = new DateTime(2023,07,17),Salary = 48000,Profession = "Developer"},
            };
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("All Persons List");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach (var person in personsList)
            {
                Console.WriteLine("Name : " + person.Name);
                Console.WriteLine("DOJ : " + person.DOJ);
                Console.WriteLine("Salary : " + person.Salary);
                Console.WriteLine("Profession : " + person.Profession);
                Console.WriteLine();
            }
            var query1 = personsList.OrderByDescending(p => p.Profession);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Persons List in Descending Order of Profession:");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach (var person in query1)
            {
                Console.WriteLine("Name: " + person.Name);
                Console.WriteLine("DOJ: " + person.DOJ);
                Console.WriteLine("Salary: " + person.Salary);
                Console.WriteLine("Profession: " + person.Profession);
                Console.WriteLine();
            }


            Console.WriteLine();
            var query2 = personsList.Where(p => p.Profession == "Developer");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("List of Developers:");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach (var developer in query2)
            {
                Console.WriteLine("Name: " + developer.Name);
                Console.WriteLine("DOJ: " + developer.DOJ);
                Console.WriteLine("Salary: " + developer.Salary);
                Console.WriteLine("Profession: " + developer.Profession);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

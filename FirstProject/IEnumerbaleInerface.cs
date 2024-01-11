using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //IEnumerable in C# is an interface that defines one method, GetEnumerator which returns an IEnumerator interface.
    //This allows readonly access to a collection then a collection that implements IEnumerable can be used with a for-each statement.
    //IEnumberable
        //-ICollection
            //-IList
            //IDictionary


    public class Employees {
        public int CustId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }

    //Like a Collection, collection implemenet IEnumerbale interface and overrides GetEnumerator()
    //so implementing IEnumerable interface so that foreach works fine otherwise will get error while using foreach
    public class Organization: IEnumerable
    {
        List<Employees> Emps = new List<Employees>();
        public void Add(Employees Emp)
        {
            Emps.Add(Emp);
        }

        public IEnumerator GetEnumerator()
        {
            return Emps.GetEnumerator();
        }
    }
    class IEnumerbaleInerface
    {
        static void Main()
        {
            //Here organization acts as a List i.e store the instances of Employees Class
            //List implements interface IEnumerable and have function GetEnumerator() used for to readonly i.e foreach
            //But Let us not override GetEnumerator() in Organization(which is implementing IEnumerable interface) then if we try to use foreach we will get error
            Organization org = new Organization();
            Employees e1 = new Employees { CustId = 121, Name = "Joe", Salary = 12000.234, Department = "Database Administrator" };
            Employees e2 = new Employees { CustId = 122, Name = "Rock", Salary = 220000, Department = "Software Engineer" };
            Employees e3 = new Employees { CustId = 123, Name = "John", Salary = 500000, Department = "Data Scientist" };
            Employees e4 = new Employees { CustId = 120, Name = "Chritain", Salary = 98800, Department = "Editor" };
            org.Add(e1);
            org.Add(e2);
            org.Add(e3);
            org.Add(e4);
            foreach (Employees obj in org)
            {
                Console.WriteLine(obj.CustId + " " + obj.Name + " " + obj.Salary + " " + obj.Department);
            }
          
            Console.ReadLine();
        }
       


}
}

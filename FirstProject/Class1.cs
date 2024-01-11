using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Class1
    {
        static void Main() {
            Console.WriteLine("Second class");
            string name = "Jay";
            int roll_no = 21;
            double salary = 21000;
            Console.WriteLine($"name={name} \n roll no = {roll_no} \n salary = {salary}");
            Console.WriteLine("\n\nname={0} \n roll no = {1} \n salary = {2}", name, roll_no, salary);
            Console.WriteLine("\n\nname = " + name + " " + "roll no = " + roll_no +" " + "salary = " + salary);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class ValueTypeTuple
    {
        static void Main()
        {
            // var person = (1, "Peter", "Male");
            //Console.WriteLine(person.Item1);
            //(int, string, string) person1 = (2, "Tina", "Female");
            //Console.WriteLine(person1.Item1);

            //var num1 = (1);//int
            //var num2 = (1, 2); //tuple
            //Console.WriteLine(num1 +" "+ num1.GetType());
            //Console.WriteLine(num2 +" " + num2.GetType());

            var num3 = (1, 2, 3, 4, 5, 6, 6, 7, 7, 8, 9, 10, 11);

            (int,EmpId,string empName,string gender) emp = 
            Console.ReadLine();
        }
    }
}

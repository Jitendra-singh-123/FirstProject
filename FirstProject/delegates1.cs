using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //Delegate: It's a type safe function pointer, which hold the reference of a method and then calls the method for execution.

    //-- To call a method by using a delegate we have 3 steps:
    // 1. Define a delegate  //[modifier] delegate [return_type] [delegate_name] ([parameter_list]);
    //ex : public delegate void AddDelegate(int x, int y);
    //public void AddNums(int a, int b)  //return type and parameters of delegate and method must be same.

    //Step1: defining the delegate
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string str);
    class delegates1
    {
        public void AddNums(int a, int b) {
            Console.WriteLine(a + b);

        }

        public static string SayHello(string name) {
            return "Hello " + name; 
        }

        static void Main()
        {
            delegates1 d = new delegates1();
            //Step2: Instantation of delegates and pass the method name as parameter to delegate constructor.
            AddDelegate ad = new AddDelegate(d.AddNums); //address of method AddNums holds by AddDelegate reference
            SayDelegate sd = new SayDelegate(SayHello);// as SayHello is static we can access it directly

            //Step3: Now call the delegate by passing required parameter values, so that internally the method which is bound with the delegate get executed.
            ad(10, 2); //OR ad.Invoke(10,2);
            string str = sd("Raju"); //OR sd.Invoke("Raju");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}

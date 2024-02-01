//importing class through  namespaces, importing class which are in namespaces to use these classes we have to import namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FirstProject//logical container used for grouping
{
    class Program
    {
        int i;
        bool b;
        //default constructors
        //Program() {
        //    i = 0;
        //    b = false;
        //}

        //explicit Constructor
        //Program() {
        //    Console.WriteLine("Constructor is called");
        //    i = 20;
        //    b = true;
        //}
        int x;
        //Parameterized constructor
        Program(int i, bool b) {
            x = i;
            Console.WriteLine("Parameterized constructor is called" + " "+ i +" " + b);
            
        }

        void Display() {
            Console.WriteLine("value of x : " + x);
        }
        static void Main(string[] args)
        {
            //Program p = new Program();

            Program p = new Program(10, true);
            Program p1 = new Program(20, false);
            //Console.WriteLine(p.i);//0
            //Console.WriteLine(p.b);//false As the values are intitlaized by default constructor

            //Console.WriteLine(p.i); // 20
            //Console.WriteLine(p.b); // true , explicit constructor is called
            p.Display();
            p1.Display();
            Console.ReadLine();
        }
    }
}

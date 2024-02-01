using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //If a class contains any static variable then only implicit static constructor will be present or else we need to define them explicilty
    //whereas non-static constructor will be implicitily defined in every class(except static class) provided we did not define them explicitly.

    //Static constructor are responsible in initializing static variables and these constructors are never called explicilty they are imopliclyt called
    //and more over these constrcutor are first to etxecute under any class.

    //static constructor can't be parameterized so overloading static constructor is not possible
    class StaticConstructor
    { 
        static int s;
        int ns;
        // Declaration of 
        // static constructor
        static StaticConstructor() { 
            Console.WriteLine("Static Constructor is executed");// first execute
        }

        // Declaration of 
        // non-static constructor 
        public StaticConstructor()
        {
            Console.WriteLine("It is non-static constructor");
        }
        static void Main() {
            Console.WriteLine("Main Method is executed"); // second execute
            // Static constructor will call implicitly 
            // as soon as the class start to execute 
            // the first block of code to execute 
            // will be static constructor 
             // Calling non-static constructor 
            
            //A static constructor will always execute once in the entire life cycle of a class.
            //But a non-static constructor can execute zero time if no instance of the class is created and n times if the n instances are created.
            StaticConstructor s1 = new StaticConstructor();
            StaticConstructor s2 = new StaticConstructor();

            //We cannot pass any parameters to the static constructors because these are called implicitly and for passing parameters,
            //we have to call it explicitly which is not possible. It will give runtime error as shown in below example.
            //However, we can pass the parameters to the non-static constructors.

            //Static constructors are used to initialize the static fields and non-static constructors are used to initialize the non-static fields.
            Console.WriteLine("Value of s is: " + s);
            // Printing the value 
            // of non-static field 
            Console.WriteLine("Value of ns is: " + s1.ns);
            Console.WriteLine("Value of ns is: " + s2.ns);
            Console.ReadLine();
        }
    }
}

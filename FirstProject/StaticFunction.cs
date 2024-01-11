using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
//    Rules for Static Methods
//Static methods can be defined using the static keyword before a return type and after an access modifier.
//Static methods can be overloaded but cannot be overridden.
//Static methods can contain local static variables.
//Static methods cannot access or call non-static variables unless they are explicitly passed as parameters.
    class StaticFunction
    {
        static int x;
        int y;
        void fun1() {
            y = 23;
            Console.WriteLine(" fun1");
        }
        //A static method in C# is a method that keeps only one copy of the method

        static void fun2()
        {
            Console.WriteLine("Fun2");
        }

        static void Main() {
            x = 34;
            StaticFunction staticFunction = new StaticFunction();
            staticFunction.y = 12;
            Console.WriteLine("x = {0} \n y={1}", x, staticFunction.y);
            staticFunction.fun1();
            fun2();
            Console.ReadLine();
        }
    }
}

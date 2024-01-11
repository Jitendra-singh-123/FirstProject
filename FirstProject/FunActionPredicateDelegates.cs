using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //Generic delegates: The Generic Delegates in C# were introduced as part of .NET Framework 3.5 which doesn’t require defining the delegate instance in order to invoke the methods

    //fun delegate is used when method has return type
    //Action delegate is used when method has void return type
    //Predicate delegate is used when method has bool return type
    
    //so instead of having these delegates we can use generic delegates 
    //public delegate double Delegate1(int x, float y, double z);
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delegate3(string str);
    class FunActionPredicateDelegates
    {
        //public static double AddNums1(int x, float y, double z) {
        //    return x + y + z;
        //}
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
               return true;
           return false;
        }
        static void Main() {
            //Delegate1 obj1 = new Delegate1(AddNums1);
            //Instead of above we can aslo do this:
            //Func<int, float, double, double> obj = new Func<int, float, double, double>(AddNums1);
            //OR
            //Func<int, float, double, double> obj1 = AddNums1; //   //Fun delegate : Func<in1 , in2 ,in3 ... , out>  ObjectName    //Here in1,in2 are inputs and out is output
            //OR using lambda expression
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
            //for below we can also use lambda expression
            double result = obj1.Invoke(100, 23.5f, 129.543);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = AddNums2;
            obj2.Invoke(100, 12.3f, 190.453);

            //can take single parameter and return type is by default bool no need to mention
            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Hello world");
            Console.WriteLine(status);
            Console.ReadKey();


        }

    }
}

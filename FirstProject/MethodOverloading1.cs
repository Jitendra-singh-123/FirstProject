using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //Method Overloading:
    //--It is the ability to redefine a function in more than one form.
    //--The methods can have the same name but with different parameters list (i.e. the number of the parameters, order of the parameters, and data types of the parameters) within the same class. 
    //The compiler does not consider the return type while differentiating the overloaded method. But you cannot declare two methods with the same signature and different return type.
    //--It will throw a compile-time error. If both methods have the same parameter types, but different return type, then it is not possible.

    //--Method overloading can be done by changing:  
    //The number of parameters in two methods.
    //The data types of the parameters of methods.
    //The Order of the parameters of methods.

    //What happens when method signature is same and the return type is different?
    //The compiler will give error as the return value alone is not sufficient for the compiler to figure out which function it has to call.
    //Only if both methods have different parameter types (so, they have the different signature), then Method overloading is possible.


    class MethodOverloading1
    {
        // adding two integer values.
        ////The number of parameters in two methods.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        ////The number of parameters in two methods.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }


        // adding three integer values.
        //By changing the Data types of the parameters
        public int Sub(int a, int b, int c)
        {
            int sum = a - b - c;
            return sum;
        }

        // adding three double values.
        //By changing the Data types of the parameters
        public double Sub(double a,
                          double b, double c)
        {
            double sum = a - b - c;
            return sum;
        }

        //By changing the Order of the parameters
        // Method
        public void Identity(String name, int id)
        {

            Console.WriteLine("Name1 : " + name + ", "
                            + "Id1 : " + id);
        }

        //By changing the Order of the parameters
        // Method
        public void Identity(int id, String name)
        {

            Console.WriteLine("Name2 : " + name + ", "
                            + "Id2 : " + id);
        }


        // adding two integer value.
        //error ambiguity while calling Add1
        //public int Add1(int a, int b)
        //{

        //    int sum = a + b;
        //    return sum;
        //}

        //// adding three integer value.
        //public double Add1(int a, int b)
        //{
        //    double sum = a + b + 0.0;
        //    return sum;
        //}
        public static void Main(String[] args)
        {

            // Creating Object
            MethodOverloading1 ob = new MethodOverloading1();

            //The number of parameters in two methods.
            int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two "
                              + "integer value : " + sum1);

            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum2);


            //By changing the Data types of the parameters
            int sub1 = ob.Sub(10, 2, 3);
            Console.WriteLine("subtract of the three "
                              + "integer value : " + sub1);
            double sub2 = ob.Sub(10.0, 2.0, 3.0);
            Console.WriteLine("subtract of the three "
                              + "double value : " + sub2);

            //By changing the Order of the parameters

            ob.Identity("Akku", 1);
            ob.Identity(2, "Abby");
            Console.ReadLine();
        }
    }
}

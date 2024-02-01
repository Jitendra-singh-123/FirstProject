using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //Generic is a class which allows the user to define classes and methods with the placeholder
    //Generic types perform better than normal system types because they reduce the need for boxing, unboxing, and type casting the variables or objects. 

    class UsuageOfGenericClass<T>
    {
        private T data;
        public UsuageOfGenericClass(T val)
        {
            data = val;
        }
        public void display()
        {
            Console.WriteLine("Inside Generics class, Hello: " + data);
        }
    }

    class UsuageOfGenericMethods
    {
        public void Display<T> (string msg,T val)
        {
            Console.WriteLine(msg,val);
            
        }
        public void Show<T1,T2> (T1 val1,T2 val2)
        {
            Console.WriteLine(val1+" "+val2);
        }
    }
    class  generics
    {
        static void Main()
        {
            UsuageOfGenericClass<string> usuageOfGenerics = new UsuageOfGenericClass<string>("Rahul");
            UsuageOfGenericClass<int> usuageOfGenerics1 = new UsuageOfGenericClass<int>(5);
            usuageOfGenerics.display();
            usuageOfGenerics1.display();

            UsuageOfGenericMethods usuageOfGenericMethods = new UsuageOfGenericMethods();
            usuageOfGenericMethods.Display<int>("Hello",7);

            UsuageOfGenericMethods usuageOfGenericMethods1 = new UsuageOfGenericMethods();
            usuageOfGenericMethods1.Show<int, string>(90,"Rahul");
            Console.ReadLine();
        }
    }
}

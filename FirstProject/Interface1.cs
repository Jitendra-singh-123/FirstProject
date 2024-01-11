using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //Rules of interface:-
    //Interfaces specify what a class must do and not how.
    //Interfaces can’t have private members.
    //By default all the members of Interface are public and abstract. so we don't require to use abstract modifier on it again just like we do in abstract class
    //The interface will always defined with the help of keyword ‘interface‘.
    //Interface cannot contain fields because they represent a particular implementation of data.
    //Multiple inheritance is possible with the help of Interfaces but not with classes.
    //we can not declare any variables under an interface.
    //If required an interface can inherit from another interface.
    //While implementing interface we don't required to use override modifier just like we use in abstract class.
    //--Generally a class inherits from another class ot use the members of its parent, where as if a class is inheriting from an interface it is to implement the members of its parent.
    //--Note : A class can inherit from a class and interface at a time.
    interface Iinterface1
    {
        void Add(int a, int b);
    }
    interface Iinterface2 : Iinterface1 {
        void sub(int a, int b);
    }
    class ImplementInterface: Iinterface2
    {
        public void Add(int a, int b) { //compuslory implemented method in base class should be public
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main() {
            ImplementInterface i = new ImplementInterface();
            i.Add(2, 3);
            i.sub(5, 2);
            Console.ReadLine();
        
        }
    }
}

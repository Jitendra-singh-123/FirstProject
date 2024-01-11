using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

    //Method Overriding: in C# is similar to the virtual function in C++.
    // Overriding is a feature that allows a subclass or child class to provide a specific implementation of a method that is already provided by one of its super-classes or parent classes. 
    //This can be performed only between parent child classes. but not within same class.
    //--while overriding parent's method under child class, child class requires a permission from it's parent.
    //--Note: If we want to override a parent's method under child class first method should be decalred by using virtual modifier in parent class.

    //--In method hiding, you can hide the implementation of the methods of a base class from the derived class using the new keyword. Or
    //in other words, in method hiding, you can redefine the method of the base class in the derived class by using the new keyword.

    //--In the first case child class re-implements it's parent class methods which are decalred as virtual, whereas in the second case child class
    //can re-implement any parent's method even if the method is not decalred as virtual.

    //--After re-implementing parent classes methods under child classes, the child class intsance will start calling the local methods only that is the re-implemented methods,
    //but if required in any case we can also call the parent classes methods from child classes by using 2 approaches.

    //--CASE 1: By creating the instance of parent class under child class we can call parent's methods from child class.
    //--CASE 2: By using the base keyword also we can call parent's method from child class, but keywords like this and base can't be used from static blocks.
    //--CASE 3: A parent class reference even if created by using the child class instance can't access any members that are purely defined under the child class but can call overriden members of child class.
    //because overriden members are not considered as pure child class members, but  members which are re-implemented by using the approach of hiding are considered as pure child class members and not accessible to parent's references.
    
    class parent {
        public virtual void show() {
            Console.WriteLine("Parent show method");
        }
        public void display() {
            Console.WriteLine("Parent display method");
        }
    }
    class MethodOverriding1: parent
    {
        public override void show()
        {
            Console.WriteLine("child show method");
        }
        public new void display() //Method hiding/shadowing
        {
            Console.WriteLine("Child display method");
        }

        public void Parentshow() {
            base.show();
        }
        public void Parentdisplay()
        {
            base.display();
        }
        static void Main() {

            //parent p = new parent();
            //p.show();//case 1
            //p.display();//case1

            parent p = new MethodOverriding1(); //CASE3: // p is a reference of parent class created by using child's instance, so p can acces parents members but not child's members,
                                                // only can acces child's member if in child class there is method overriding because child class members take permission before overriding using virtual keyword
                                                // therefore parent can identify childs members too.
            p.show();// CASE 3:invokes child class show(), as p can access child method as child member takes permission from parent so parent can identify childs members
            p.display();//CASE3: shows parent class display() as there is not permission taken by child class for display method from parent method display

            MethodOverriding1 m1 = new MethodOverriding1();
            //m1.Parentshow();//case2
            //m1.Parentdisplay();//case2
            //m1.show();
            //m1.display();
            Console.ReadLine();
        }
    }
}

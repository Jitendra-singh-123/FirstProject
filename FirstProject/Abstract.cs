using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Data abstraction is the process of hiding certain details and showing only essential information to the user
//--Abstract method with out any body.
//--Abstract class which contains any abstract members in it.

//Rules:
//An abstract class is declared with the help of abstract keyword.
//In C#, you are not allowed to create objects of the abstract class. Or in other words, you cannot use the abstract class directly with the new operator.
//Class that contains the abstract keyword with some of its methods(not all abstract method) is known as an Abstract Base Class.
//Class that contains the abstract keyword with all of its methods is known as pure Abstract Base Class.
//You are not allowed to declare the abstract methods outside the abstract class.
//You are not allowed to declare an abstract class as Sealed Class.
//You are not allowed to declare an abstract class as Static Class.
//we can use non-abstract method in child class only when we provide the implementation of abstract methods.

//--Encapsulation is data hiding(information hiding) while Abstraction is detail hiding(implementation hiding).
namespace FirstProject
{
    abstract class Shape
    {
        // abstract method
        public abstract int area();
        public void display() {
            Console.WriteLine("Non abstract method");
        }
    }

    // square class inheriting
    // the Shape class
    class Square : Shape
    {
        public void show() {
            Console.WriteLine("Child show method");
        }
        // private data member
        private int side;

        // method of  square class
        public Square(int x)
        {
            side = x;
        }

        // overriding of the abstract method of Shape
        // class using the override keyword
        public override int area()//compulsory override keyword must be used
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
    class Abstract
    {
        static void Main() {
            //Shape s = new Shape();//can not create instance of abstract class
            Square sq = new Square(2);
            Console.WriteLine(sq.area());
            Shape s = new Square(3);
            Console.WriteLine(s.area()); 
            //parent reference can used to call child area method because it is overriden i.e parent knows the area method is been overriden in child class as child class has taken the permission.
            //If we are not able to create instance of abstract class then can we call its non-abstract methods?
            //Yes, through parent reference on child instance or making non-abstract method as static so that we can access that method in main method using class(className.non-abstract static method)
            s.display();

            Console.ReadLine();

        }
    }
}

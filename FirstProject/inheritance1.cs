using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //Inheritance is the concept of OOPs where we can resuse the parent class members in child class


    //// multi-level inheritance
    //class Mammal : Animal
    //{
    //    public void Run()
    //    {
    //        Console.WriteLine("Mammal is running.");
    //    }
    //}

    //class Horse : Mammal
    //{
    //    public void Gallop()
    //    {
    //        Console.WriteLine("Horse is galloping.");
    //    }
    //}

    //// hierarchical inheritance
    //class Bird : Animal
    //{
    //    public void Fly()
    //    {
    //        Console.WriteLine("Bird is flying.");
    //    }
    //}

    //class Eagle : Bird
    //{
    //    public void Hunt()
    //    {
    //        Console.WriteLine("Eagle is hunting.");
    //    }
    //}

    //class Penguin : Bird
    //{
    //    public void Swim()
    //    {
    //        Console.WriteLine("Penguin is swimming.");
    //    }
    //}
    // single inheritance
    class Animal
    { 
        public Animal( ) { 
            Console.WriteLine("Parent Constructor" );
        }
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
       public Dog() {
            Console.WriteLine("Child Constructor");
        }
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    class inheritance
    {
        static void Main()
        {
            // single inheritance
            //Parent class constructor must be accessible to child class, otherwise inheritance will not be possible.
            Dog dog = new Dog();//implicit  constructor  of child will call the parent constructor first (if it is public).
            //dog.Eat();
            //dog.Bark();
            Console.WriteLine(dog.GetType());
            Object o = (Object)dog;// Dog type
            Console.WriteLine(o.GetType());
           
            Object obj = new object();
            Console.WriteLine(obj.GetType());
            
            Animal a = new Animal();
            Console.WriteLine(a.GetType());

            //Animal a = new Dog();
            //a.bark(); //although Parent object 'a' is refrencing Child object but it can not access the members of child class

            //Every class that is defined by us or pre-defined in the libraries of the language has a default parent class i.e. Object
            //class of system namespace, so the members of Object class(Equals, GetHashCode, GetType, ToString) are accessible from any where.
            //Like here Object class is parent of Animal class and Animal class is the Parent of Dog class and Object class is the grandparent of Dog class
            //i.e here it follows the multilevel inheritance.

            //// multi-level inheritance
            //Horse horse = new Horse();
            //horse.Eat();
            //horse.Run();
            //horse.Gallop();

            //// hierarchical inheritance
            //Eagle eagle = new Eagle();
            //Penguin penguin = new Penguin();
            //eagle.Fly();
            //eagle.Hunt();
            //penguin.Fly();
            //penguin.Swim();



            Console.ReadLine();
        }

    }
}
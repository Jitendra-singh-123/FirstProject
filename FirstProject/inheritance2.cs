using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Parent {
        int i;
       public Parent(int i) {
            Console.WriteLine("parent Constructor " + i);
            this.i = i;
        }
        public void parent() {
            Console.WriteLine("Parent Method");
        }
    }
    class inheritance2 : Parent
    {
        //public inheritance2() : base(20) //if the constructor of parent class is parameterized, child class constructor can't implicitly call it's parent's
            //constructor, so to overcome the problem  it is the responsibility of the programmer to explicitly call parent classes constructor from child class
            //constructor and pass values to those parameters using base(parameters).
        public inheritance2(int i): base(i)
        {
            Console.WriteLine("Child constructor");
        }
        void child()
        {
            Console.WriteLine("child Method");
        }
        static void Main() {
            //inheritance2 i2 = new inheritance2();
            inheritance2 i3 = new inheritance2(50);
            // i2.parent();
            // i2.child();
            i3.parent();
            i3.child();
            Console.ReadLine();

        }

    }
}

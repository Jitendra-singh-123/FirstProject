using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //Copy Constructor : if we want to create multiple instances with same value then we use these copy constructor, in a copy constructor the constructor takes the same class as a parameter to it.

    class CopyConstructor
    {
        int x;
        public CopyConstructor(int i) {
            x = i;
        }

        public CopyConstructor(CopyConstructor obj) //copy constructor
        {
            x = obj.x;
        }
        public void Display() {
            Console.WriteLine("Value of x is :" + x);
        }
        static void Main() {
            CopyConstructor cd1 = new CopyConstructor(10);
            cd1.Display();
            CopyConstructor cd2 = new CopyConstructor(cd1);
            cd2.Display();
            Console.ReadLine();
        }
    }
}

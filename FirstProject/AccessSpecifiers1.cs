using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //Access Specifiers
    // public: no restriction at all, can be accessed from anywhere
    //private : can be accessed within same class
    //protected : can be accessed wihtin the class and through the child class
    //internal :  can be accessed within the project thrugh child or non-child class
    //protected internal : can be accessed either within the project or within the child class of other projects
    //protected internal follows OR boolean table like:
    //internal     protected      protected internal
    //T            T               T
    //T             F               T
    //F             T               T
    //F             F               F    //if protected and internal are not accessible then protected interal is also not accessible
    
    //with class we can use public, and internal(default)
    //default members of class members are private
    //CASE1: using members of a class from same class
    public class AccessSpecifiers1
    {
        private void Test1() {
            Console.WriteLine("Private Method");
        }
        internal void Test2() {
            Console.WriteLine("Internal Method");
        }
        protected void Test3()
        {
            Console.WriteLine("protected Method");
        }
        protected internal void Test4() {
            Console.WriteLine("Protected internal method");
        }
        public void Test5()
        {
            Console.WriteLine("public Method");
        }
        static void Main()
        {
            AccessSpecifiers1 a1 = new AccessSpecifiers1();
            a1.Test1();
            a1.Test2();
            a1.Test3();
            a1.Test4();
            a1.Test5();
            Console.ReadLine();
        }
    }
}

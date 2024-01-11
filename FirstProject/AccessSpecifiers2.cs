using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class AccessSpecifiers2 : AccessSpecifiers1
    {
        //CASE2: using members of parent class from child class
        static void Main() {
            AccessSpecifiers2 a2 = new AccessSpecifiers2();
            a2.Test2();
            a2.Test3();
            a2.Test4();
            a2.Test5();
            Console.ReadLine();
        }
    }
}

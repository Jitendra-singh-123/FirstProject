using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class AccessSpecifiers3
    {
        //CASE3: Using members of a class from non-child classs
        static void Main() {
            AccessSpecifiers1 a1 = new AccessSpecifiers1();
            a1.Test2();
            a1.Test4();
            a1.Test5();
            Console.ReadLine();
        }
    }
}

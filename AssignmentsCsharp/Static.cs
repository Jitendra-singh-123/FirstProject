using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    class Static
    {
        static int callCount;
        public static void CountFunction() {
            callCount++;
            Console.WriteLine("Function called {0} ", callCount);
        }
        static void Main() {
            Static.CountFunction();
            Static.CountFunction();
            Static.CountFunction();
            Static.CountFunction();
            Static.CountFunction();

            Console.ReadLine();
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    class AssignmentTraineer3
    {
        static void Main() {
            for (int i = 0; i < 5; i++) {
                for (int j = i; j < 5; j++) {
                    Console.Write(" ");
                }
                for (int k = 0; k <=i ; k++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

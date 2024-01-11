using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class ParamArray
    {
        //Params is an important keyword in C#. It is used as a parameter which can take the variable number of arguments.
        static void Main() {
            Console.WriteLine(SumParameters(1));
            Console.WriteLine(SumParameters(1,2));
            Console.WriteLine(SumParameters(1,2,3));
            Console.ReadLine();
        
        }

        static int SumParameters(params int[] values)
        {
            int total = 0;
            foreach (int value in values) {
                total += value;
            }
            return total;
        }
    }
}

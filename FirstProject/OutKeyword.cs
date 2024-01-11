using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class OutKeyword
    {   
        static void Calculate(int a,int b,out int sum,out int diff,out int multiply)
        {
            sum = a + b;
            diff = a - b;
            multiply = a * b;
        }
        static void Main()
        {
            Calculate(100, 40,out int sum1,out int diff1,out int multiply1);
            Calculate(200, 20, out int sum2, out _, out _);
            Console.WriteLine($"Sum: {sum1} \n Difference: {diff1} \n Multiply: {multiply1}");
            Console.WriteLine($"\nSum: {sum2}");
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //Lambda expressions in C# are used like anonymous functions, with the difference that in Lambda expressions you don’t need to specify the type of the value that you input thus making it more flexible to use. 
    //The ‘=>’ is the lambda operator which is used in all lambda expressions.The Lambda expression is divided into two parts, the left side is the input and the right is the expression.

    //The Lambda Expressions can be of two types: 
    //Expression Lambda: Consists of the input and the expression.
    //Syntax:
    //input => expression;

    //Statement Lambda: Consists of the input and a set of statements to be executed.
    //Syntax:
    //input => { statements };
class LambdaExpression1
    {
        static void Main() {
            //statement Lambda
            GreetingsDelegate obj =  (name) =>
            {
                return "Hello " + name + " good morning.";
            };
            string str = obj.Invoke("Scott");
            Console.WriteLine(str);

            //Expression Lambda
            int[] numbers = { 2, 3, 4, 5 };
            var square = numbers.Select(x => x * x);

            // foreach loop to display squares
            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
            // Output:
            // 4 9 16 25
            Console.ReadLine();
        }
    }
}

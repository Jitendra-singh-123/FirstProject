using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //An anonymous method is a method which doesn’t contain any name which is introduced in C# 2.0.
    //It is useful when the user wants to create an inline method and also wants to pass parameter in the anonymous method like other methods. An Anonymous method is defined using the delegate keyword and the user can assign this method to a variable of the delegate type.
    public delegate string GreetingsDelegate(string name);
    class AnonymousMethods
    {
        //public static string Greetings(string name) {
        //    return "Hello " + name + "good morning.";
        //}
        static void Main()
        {
            // GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            //Method without name but just body
            GreetingsDelegate obj = delegate (string name)
            {
                return "Hello " + name + " good morning.";
            };

            string str = obj.Invoke("Scott");
            Console.WriteLine(str);
            Console.ReadLine();


        }
    }
}

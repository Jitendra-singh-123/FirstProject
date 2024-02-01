using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //putting constraint to the class
    public class OurClass<T,U> where U : class where T: struct
    {
        T fieldOne;
        U fieldTwo;
        public OurClass(T param1,U param2)
        {
            fieldOne = param1;
            fieldTwo = param2;
        }
        public void Display()
        {
            Console.WriteLine("First Field Info: {0} and DataType: {1}" , fieldOne,fieldOne.GetType());
            Console.WriteLine("Second Field Info: {0} and DataType: {1}" , fieldTwo,fieldTwo.GetType());
        }
    }
    
    class Generics1
    {
        static void Main()
        {
            //first parameter should be value type and second should be referece type
            OurClass<int, string> ourClass = new OurClass<int, string>(12, "sam");
            OurClass<char, object> ourClass1 = new OurClass<char, object>('A', "sam12");
           //error OurClass<object, char> ourClass2 = new OurClass<object, char>("jay12", 'Z');
            ourClass.Display();
            ourClass1.Display();
            Console.ReadLine();
        }
    }
}

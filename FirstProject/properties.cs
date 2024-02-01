using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //why the concept of properties came into C#? The is because of two reasons:
    //If the members of a class are private then how another class in C# will be able to read, write, or compute the value of that field.
    //If the members of the class are public then another class may misuse that member.

    //Properties are the special type of class members that provides a flexible mechanism to read, write, or compute the value of a private field.

    //Accessors: The block of “set” and “get” is known as “Accessors”. It is very essential to restrict the accessibility of property.
    //There are two type of accessors i.e. get accessors and set accessors. There are different types of properties based on the “get” and “set” accessors:

    //Read and Write Properties: When property contains both get and set methods.
    // Read-Only Properties: When property contains only get method.
    //Write Only Properties: When property contains only set method.
    //Auto Implemented Properties: When there is no additional logic in the property accessors and it introduce in C# 3.0.
    class BankInterest {
       private decimal _rateOfInterest = 6.43M;
        //Interest Properties using get and set accessors
       //public decimal rateOfInterest { 
       //     get { return _rateOfInterest; }
       //     set { _rateOfInterest = value; }
       // }
      // public decimal rateOfInterest { get; set; }
        public decimal rateOfInterest
        {
            get { return _rateOfInterest; }
            set {
                if (value < _rateOfInterest)
                    _rateOfInterest = value;
            }
        }

    }
    class properties
    {
        static void Main() {
            BankInterest b = new BankInterest();
            //calling set accessor
            b.rateOfInterest = 7;
            //calling get accessor
            Console.WriteLine("Rate Of Interest in bank is: {0} ", b.rateOfInterest);
            //instead of properties we can also access the class members by making variable(_rateOfInterest) as public then we to use properties?
            //because sometimes we want to put conditions like before setting the new value it should check the previous value so we can put if, else in set property
            //Like no one modify the _rateOfInterest variable if it is greater than defined value i.e 6.43;
            Console.ReadLine();
        }
    }
}

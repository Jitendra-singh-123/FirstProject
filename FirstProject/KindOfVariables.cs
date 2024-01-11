using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //1. Non-static/instance 

    //2. Static : If a variable is explicitly decalred by using the static modifier
    //or else if a variable is declared under any static block then those variable are static whereas rest are non-static
    //--Note: Static members of a class doesn't require the instance of class for intializtion or execution also,
    //where as non-static members of a class requires the instance of class both for intializtion and execution.
    //--static variables of a class are intialized immediately once he execution of class starts whereas  instance variable are intiliazed only after
    //creating the class instance as well as each and every time the instance of class is created.
    //--In a life cycle of a class a static variable is intialized one and only one time, whereas instance variables are intialized for 0 times
    //if no instance are created and n times if n instances are created.

    //3. Constants: If a variable is decalared by using  the keyword "const" we call it as constant variable and these constant variable can't be modified once after
    //their decalration, so it is must to intialize constant varibale at the time of decalration only, otherwise we will get error.
    //-- The behaviour of constant variables will be similar to the behaviour of static variables i.e. intialized one and only one time in the life cycle of a class a
    //doesn't require the instance of a class for accessing and initializing.
    //--The only difference in const and static is static variable can be modified but not constant variables

    //4. ReadOnly: these variables also can't be modified like constants but after intialization. It is not compulsory to intialize a readonly variable at the time of declaration
    //they can aslo be intialized under the constructor.
    //--The behaviour of readonly variables will be similar to the behaviour of non-static variables, that is intialized only after creating the instance of class and once for each instance
    //of the class created.
    //--The only difference between readonly and intance variables is instance variables can be modified but not readonly variables
    //--Constant Variable is a fixed value for the whole class whereas readonly variables is a fixed value specific to an instance of a class
    class KindOfVariables
    {
        int x=100;// Non-static
        static int y=200;//static
        const float PI = 3.14f;// constant variable
        readonly bool flag;
        KindOfVariables(int x , bool flag) {
            this.flag = flag;
            this.x = x;
        }
        static void Main() {
            int z = 300;//static variable
            Console.WriteLine(y+ " "+ z+ " PI: " + PI);//for Const no need to create instance
            KindOfVariables k1 = new KindOfVariables(20,true);
            KindOfVariables k2 = new KindOfVariables(30, false);
            Console.WriteLine(k1.x + " "+ k2.x);
            Console.WriteLine(k1.flag+ " " + k2.flag);
            k1.x = 50;
            //k1.flag = false;  //can't be modified once intialization 
            Console.ReadLine();
        }
    }
}

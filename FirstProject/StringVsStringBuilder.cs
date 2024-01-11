using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace FirstProject
{
    //Once we create a string object, we can’t perform any changes in the existing object. If we are trying to perform any changes with those changes a new object will be created, this non-changeable behaviour is immutability of a string.
    //Once we create StringBuffer Object, we can perform any change in the existing object. This changeable behaviour is mutability of StringBuffer Object.

    class StringVsStringBuilder
    {
        static void Main() {
            //string str = "hello ";
            //string str1 = "hello ";
            //String str2 = "hello ";
            //Console.WriteLine(str.GetHashCode());//hash code of str
            //Console.WriteLine(str1.GetHashCode());//hash code of str1, both hash code str1 and str are same
            //Console.WriteLine(str2.GetHashCode());//still hash code of str3 also same
            //str = str + "World ";
            //Console.WriteLine(str.GetHashCode());//hash code of str
            //str = str + "America";
            //Console.WriteLine(str.GetHashCode());// hash code of str, all the hash code will be different
            //Console.WriteLine(str);

            //Console.WriteLine();
            //StringBuilder sb = new StringBuilder("Hello ");
            //StringBuilder ss = new StringBuilder("Hello");
            //Console.WriteLine("Hash code of ss: " + ss.GetHashCode());//Hash code of ss
            //Console.WriteLine("Hash code of sb: " + sb.GetHashCode());// hash code of sb, ss and sb hash code will be different
            //sb.Append("world ");
            //Console.WriteLine("Hash code of sb: " + sb.GetHashCode());// hash code of sb
            //sb.Append("India");
            //Console.WriteLine("Hash code of sb: "+  sb.GetHashCode());//hash code of sb, all are same
            //Console.WriteLine(sb);


            ////StringBuilder sb1 = new StringBuilder(20);// of capacity 20 and once the capacity fulls it increase current_capacity*2;
            ////StringBuilder sb2 = new StringBuilder("Hello", 20);// we pass string value with an integer value (that is the maximum capacity of character a string can hold) as an argument to the constructor.

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            string s = "";

            for (int i = 0; i < 100000; i++)
                s = s + i;

            sw1.Stop();

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 100000; i++)
                sb.Append(i);
            sw2.Stop();

            Console.WriteLine("Time for string : " + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time for stringBuilder : " + sw2.ElapsedMilliseconds);


            Console.ReadLine();
        }
    }
}

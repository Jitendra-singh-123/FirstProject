using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //if you see that your methods have same return type and parameter, it is prefered to use multicast delegates
    //Multicasting of delegate is an extension of the normal delegate (sometimes termed as Single Cast Delegate). It helps the user to point more than one method in a single call.
    public delegate void RectDelegate(double Width, double Height);
    class MultiCastDelegate
    {
        public void GetArea(double Width, double Height) {
            Console.WriteLine("Area of rectangle: " + Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Paramter of rectangle: "+ 2 * (Width + Height));
        }
        static void Main() {
            MultiCastDelegate mcd = new MultiCastDelegate();
            RectDelegate rd = new RectDelegate(mcd.GetArea);
            //Throuh multicast delegate we don't need to call multiple methods through delegate reference,
            //instead we can bind all the methods through one delegate reference

            //multicast delegate are best to use for void return type otherwise first GetArea we will return its value then GetParameter will return its value due to which 
            //value of GetArea is overridden by GetParameter
            rd += mcd.GetPerimeter;
            rd.Invoke(12.34, 34.21);
            Console.ReadKey();


        }
    }
}

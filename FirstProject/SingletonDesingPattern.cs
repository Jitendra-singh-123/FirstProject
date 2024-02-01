using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public sealed class Singleton
    {
        private static int numberOfObjects = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton()
        {
            numberOfObjects++;
            Console.WriteLine("Counter on Increasing: " + numberOfObjects);

        }

        public void PrintDetails()
        {
            Console.WriteLine("Number of Objects: "+ numberOfObjects);
        }


    }
    class SingletonDesingPattern
    {

        static void Main()
        {
            Singleton singleton = Singleton.GetInstance;
            Singleton singleton1 = Singleton.GetInstance;

            singleton.PrintDetails();
            singleton1.PrintDetails();

            if(singleton1 == singleton)
                Console.WriteLine("Both objects are same");
            else
            {
                Console.WriteLine("Both objects are different");
            }
            Console.ReadLine();
        }
    }
}

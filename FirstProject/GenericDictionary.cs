using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    
   
    class GenericDictionary
    {
        static void Main()
        {
            //Dictionary is a generic collection which is generally used to store key/value pairs.
            //The working of Dictionary is quite similar to the non-generic hashtable. 
            //There is  sequence of key value pair in dictionary but not in HashTable.

            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("Eid", 101);
            dt.Add("Name", "Rahul");
            dt.Add("Email", "Rahul21@gmail.com");
            dt.Add("Phone", "+91349128323");
            dt.Add("Address", "St. Thomas Street");

            foreach (string key in dt.Keys) {
                Console.WriteLine(key + " : " + dt[key]);
            }

            
            Console.ReadLine();
        }
    }
}

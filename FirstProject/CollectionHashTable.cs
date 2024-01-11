using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FirstProject
{
    class CollectionHashTable
    {
        static void Main() {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 101);
            ht.Add("Name", "Rahul");
            ht.Add("Email", "Rahul21@gmail.com");
            ht.Add("Phone", "+91349128323");
            ht.Add("Address", "St. Thomas Street");

            foreach (object key in ht.Keys) {
                Console.WriteLine(key + " : " + ht[key]);
                
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FirstProject
{
    //Collections, it contains a set of classes to contain elements in a generalized manner.
    //With the help of collections, the user can perform several operations on objects like the store, update, delete, retrieve, search, sort etc.

    //Collections
    //System.Collection.Generic (generic collections) : data structure like linked lists, stacks, queues, and dictionaries.
    //System.Collections(non-generic collections) : ArrayList, HashTable, Queue, Stack
    class CollectionArrayList
    {
        //Non-Generic collections
        //ArrayList
        static void Main() {
            ArrayList al = new ArrayList();//by default size of array list is 4
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200); al.Add(300); al.Add(400);//once the capacity full then it increase by currentSize * 2
            Console.WriteLine(al.Capacity);
            al.Add(500);
            Console.WriteLine(al.Capacity);//8

            foreach (object obj in al)
                Console.WriteLine(obj + " ");
            Console.WriteLine();

            al.Insert(3, 350);
            foreach(object obj in al)
                Console.WriteLine(obj + " ");
            Console.WriteLine();

            //al.Remove(200);

            al.RemoveAt(1);
            foreach(object obj in al)
                Console.WriteLine(obj + " ");
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //Generic collection in C# is defined in System.Collection.Generic namespace. It provides a generic implementation of standard data structure like linked lists, stacks, queues, and dictionaries.
    //These collections are type-safe because they are generic means only those items that are type-compatible with the type of the collection can be stored in a generic collection, it eliminates accidental type mismatches.
    //For every classes in non-generic collection we have alternatives in generic collcetions.
    //ex: ArrayList in non-generic(not type safe i.e. can store any type of value) collections and List in generic collections(type safe i.e can store only particular type value)

    class GenericCollection
    {
        static void Main() {
            List<int> firstlist = new List<int>();

            // adding elements in firstlist 
            firstlist.Add(10);//argument of Add method is of type whereas in case of ArrayList it is of type object
            firstlist.Add(20);
            firstlist.Add(30);
            firstlist.Add(40);

            // Printing the Capacity of firstlist 
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist 
            Console.WriteLine("Count Is: " + firstlist.Count);

            // Adding some more 
            // elements in firstlist 
            firstlist.Add(50);
            firstlist.Add(60);

            firstlist.Insert(3, 35);

            // Printing the Capacity of firstlist 
            // It will give output 8 as internally 
            // List is resized 
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist 
            Console.WriteLine("Count Is: " + firstlist.Count);
            foreach (int i in firstlist) {
                Console.WriteLine(i + " ");
            }
            Console.ReadLine();
        }

    }
    }


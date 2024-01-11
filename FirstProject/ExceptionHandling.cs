using System;

namespace FirstProject
{
    //Exception: An unexpected unwanted event that disrupts the normal flow of the program is called exception.   
    //It is highly recommended to handle exceptions and the main objective of exception handling is graceful termination of the program.

    //System Level Exception
    //System exceptions are derived from the base class System.SystemException which in itself is a derived class of SystemException.
    // A System Exception occurs when a fatal or non-recoverable error is encountered, like a database crash, bound errors etc.

    //Application Level Exception
    //Application-level exceptions are derived from the base class System.ApplicationException which is also a derived class of SystemException.
    //An Application-level exception occurs when a recoverable error is encountered, for example, the wrong type of input data, arithmetic exceptions etc.


    //Whenever we are writing try compulsory, we should write either catch or finally otherwise we will get compile time error i.e., try without catch or finally is invalid.
    //whenever we are writing catch block, compulsory try block must be required i.e., catch without try is invalid.
    //Whenever we are writing finally block, compulsory we should write try block i.e., finally without try is invalid.
    //Inside try, catch, and finally blocks we can declare try, catch, and finally blocks i.e., nesting of try, catch, finally is allowed.

   // Finalize() :
   // Finalize is a method always invoked by garbage collector just before destroying object to perform clean-up activities.Once finalize method completes immediately garbage collector destroys that object.
   // Note: Finally block is responsible to perform clean-up activities related to try block i.e.whatever resource we open at the part of try block will be closed inside finally block.
   // Whereas finalize method is responsible to perform clean-up activities related to object i.e., whatever resource associated with object will be deallocated before destroying object by using finalize method.

    //Note: try to put less code in try block
    class ExceptionHandling
    {
        static void Main()
        {
          
            try
            {
                Console.WriteLine("Inside try block");
                int x = 10;
                int y = 0;
                int result = x / y; // This will throw a DivideByZeroException
                Console.WriteLine("Result: " + result);
                int[] arr = { 1, 2, 3, 4, 5 };
                Console.WriteLine(arr[7]);
                
            }

            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //catch (IndexOutOfRangeException i) {
            //    Console.WriteLine(i.Message);
            //}

            //OR 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            finally {
                Console.WriteLine("Will excecute irrespective of try catch");
                 Console.WriteLine("rest of the code");
                Console.ReadLine();
            }

      



            Console.ReadLine();

        }
    }
}

//Exception heirarchy
//ApplicationException
   // Your own exception types

//SystemException
//    ArgumentException
//        ArgumentNullException
//        ArgumentOutOfRangeException
//    DivideByZeroException
//    IndexOutOfRangeException
//    NullReferenceException
//    RankException
//    StackOverflowException
//    IOException
//        EndOfStreamException
//        FileNotFoundException
//        FileLoadException
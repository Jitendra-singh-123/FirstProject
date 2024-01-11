using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class CheckForVote : ApplicationException
    { 
        public override string Message
        {
            get {
                return "Not allowed to vote";
            }
        }
        //OR
        //public override string ToString()
        //{
        //    return "Not allowed to vote";
        //}
    }
    class UserDefinedExceptions
    {
        static void Main() {
            int age = 17;
            try
            {
                if (age <= 18)
                {
                    throw new CheckForVote();
                }

            }

            catch (CheckForVote e) {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e); // if we uncomment ToString method from above then we can use this
            }

            Console.ReadLine();
        }
    }
}

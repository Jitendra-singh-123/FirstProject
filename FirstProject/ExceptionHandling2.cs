using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In case of SystemException CLR Raises and throw the exception like divide by zero but in ApplicationException Programmer raise and throw the exception


namespace FirstProject
{
    class ExceptionHandling2
    {
        public static void ValidAge(int age)
        {
            if (age < 18)
            {
                throw new ApplicationException("You cannot enter the bar as your age is less than 18");
            }
            else
                Console.WriteLine("Allowed");
        }

        static void Main()
        {
            int Age = 16;
            try
            {
                ValidAge(Age);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}

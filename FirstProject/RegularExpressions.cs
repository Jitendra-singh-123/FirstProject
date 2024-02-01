using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstProject
{
    class RegularExpressions
    {
        static void Main()
        {
            //    string pinCode;
            //    Console.WriteLine("Enter your pincode");
            //    pinCode = Console.ReadLine();
            //    string pattern = @"^\d{6}$";
            //    Regex regex = new Regex(pattern);
            //    if(regex.IsMatch(pinCode))
            //        Console.WriteLine("Your pincode is = " + pinCode);
            //    else
            //        Console.WriteLine("Invalid Pincode");

            //either capital T or small t
            //string pattern = "[Tt]im";
            //string pattern1 = "Tim";
            //Console.WriteLine(Regex.IsMatch("Tim corey",pattern));//true
            //Console.WriteLine(Regex.IsMatch("tim corey",pattern));//true
            //Console.WriteLine(Regex.IsMatch("tim corey",pattern1,RegexOptions.IgnoreCase));//true



            //* ->Used to match the preceding character zero or more times
            //Console.WriteLine(Regex.IsMatch("bb","a*b"));//a zero or more than 0 times

            //Console.WriteLine(Regex.IsMatch("abb", "a+b"));//a one or more than 1 times
            //Console.WriteLine(Regex.IsMatch("abb", "a?b"));//a zero or one times
            // Console.WriteLine(Regex.IsMatch("aaabaab", "a{3}"));//a must occur three times
            // Console.WriteLine(Regex.IsMatch("aaaabb", "a{3,}"));//a atleast match the character 3 times
            // Console.WriteLine(Regex.IsMatch("aaaabb", "a{3,5}"));//a atleast matches three to five times
            //Console.WriteLine(Regex.IsMatch("Shyam is my pet name", "^Shyam"));//Word after this element matches at the beginning of the string or line.
            //Console.WriteLine(Regex.IsMatch("My name is Parth","Parth$"));//Word before this element matches at the end of the line or string.
            //Console.WriteLine(Regex.IsMatch("abcda", "a."));//macthces 'a' only once
            //Console.WriteLine(Regex.IsMatch("acdbcaa", "a..b"));// after a and b we should have two charcters
            //Console.WriteLine(Regex.IsMatch("121", @"\d"));//just check only one digit character anywhere in pattern

            //Console.WriteLine(Regex.IsMatch("asds", @"\D"));//just check only non-digit character anywhere in string pattern
            // Console.WriteLine(Regex.IsMatch("asa12_", @"\w"));//matches any alphanumeric characters(either having alphabet or number or underscore or all) and underscore character
            //Console.WriteLine(Regex.IsMatch("My name is Parth  ", @"\sParth\s"));//used to match the white space character
            //Console.WriteLine(Regex.IsMatch("MyParthName", @"\SParth\S"));//used to match non white space characters

            // Console.WriteLine(Regex.IsMatch("ecadf", @"[abc]"));//matches one character either a or b or c

            //Console.WriteLine(Regex.IsMatch("9874", @"[1-5]"));//check character between 1 to 5 inclusive,if any character of pattern present in regex range it return true
            //Console.WriteLine(Regex.IsMatch("314", @"[^1-5]"));//It is used to match any character not in the range of 1-5

            // Console.WriteLine(Regex.IsMatch("cdcdee", @"(cd)+"));//() usde for grouping and here whole cd should be present one or more than one times
            // Console.WriteLine(Regex.IsMatch("ee", @"(cd)*"));//cd should be present zero or more than zero times

            //Console.WriteLine(Regex.IsMatch("edge", @"d|e"));//either d or e matches


            //assingment
            //Phone number formats:
            //xxxxxxxxxx, +xx xx xxxxxxxx, xxxx - xxx - xxx
            //use \d or [0-9]
            string strRegex = @"(^\d{10}$)|(^\+[0-9]{2}\s+[0-9]{2}\s+[0-9]{8}$)|(^[0-9]{4}-[0-9]{3}-[0-9]{3}$)";
//            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

            Regex re = new Regex(strRegex);
            if (re.IsMatch("098127654321"))
            {
                Console.WriteLine("valid phone number");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.Read();


        }
    }
}
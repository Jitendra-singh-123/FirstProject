using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FirstProject
{
    class FileHandling1
    {
        static void Main()
        {
            int choice, flag;
            do
            {
                Console.WriteLine("File Handling Operations:     ");
                Console.WriteLine("\t 1. Create");
                Console.WriteLine("\t 2. Write");
                Console.WriteLine("\t 3. Append");
                Console.WriteLine("\t 4. Delete");
                Console.WriteLine("\nChoose your Option:\t");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        File.Create(@"C:\Users\acer\Dropbox\My PC (LAPTOP-FDJLT93A)\Desktop\c#\FirstProject\FirstProject\sample.txt");
                        break;
                    case 2:
                        string cont;
                        Console.WriteLine("Enter the Contents to write");
                        cont = Console.ReadLine();
                        File.WriteAllText(@"C:\Users\acer\Dropbox\My PC (LAPTOP-FDJLT93A)\Desktop\c#\FirstProject\FirstProject\sample.txt", cont);
                        Console.WriteLine("\nFile Contents: ");
                        Console.WriteLine(File.ReadAllText(@"C:\Users\acer\Dropbox\My PC (LAPTOP-FDJLT93A)\Desktop\c#\FirstProject\FirstProject\sample.txt"));
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contents to append: ");
                        cont = Console.ReadLine();
                        File.AppendAllText(@"C:\Users\acer\Dropbox\My PC (LAPTOP-FDJLT93A)\Desktop\c#\FirstProject\FirstProject\sample.txt", cont);
                        Console.WriteLine("\nFile Contents: ");
                        Console.WriteLine(File.ReadAllText(@"C:\Users\acer\Dropbox\My PC (LAPTOP-FDJLT93A)\Desktop\c#\FirstProject\FirstProject\sample.txt"));
                        break;
                    case 4:
                        File.Delete(@"C:\Users\acer\Dropbox\My PC (LAPTOP-FDJLT93A)\Desktop\c#\FirstProject\FirstProject\sample.txt");
                        break;
                    default:
                        Console.WriteLine("Choose the correct Option: ");
                        break;
                }
                Console.WriteLine("Enter 0 to continue: ");
                flag = int.Parse(Console.ReadLine());

            } while (flag == 0);
            Console.ReadKey();
        }
    }
}

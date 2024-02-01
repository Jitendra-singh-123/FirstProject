using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{

    class AssingmentSalaryCalculation
    {
        
        static void Main()
        {
            Console.WriteLine("Choose Employee Type: ");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software");
            int employeeType = int.Parse(Console.ReadLine());
            switch (employeeType)
            {
                case 1:
                    Console.WriteLine("Enter working Hour:");
                    int hrWorkingHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Number Of working Days:");
                    int hrWorkingDays = int.Parse(Console.ReadLine());
                    CalculateSalary(hrWorkingHour, hrWorkingDays);
                    break;

                case 2:
                    Console.WriteLine("Enter working Hour:");
                    int adminWorkingHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Number Of working Days:");
                    int adminWorkingDays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Project Handles:");
                    int projectHandles = int.Parse(Console.ReadLine());
                    CalculateSalary(adminWorkingHour, adminWorkingDays, projectHandles);
                    break;

                case 3:
                    Console.WriteLine("Enter working Hour:");
                    int devWorkingHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Number Of working Days:");
                    int devWorkingDays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Project Handles:");
                    int devProjectHandles = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Extras:");
                    int extras = int.Parse(Console.ReadLine());
                    CalculateSalary(devWorkingHour, devWorkingDays, devProjectHandles, extras);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadLine();
        }

        static void CalculateSalary(int workingHour, int workingDays, int projectHandles = 1, int extras = 0)
        {

            int totalSalary = workingHour * workingDays * 100 + projectHandles * 3000 + extras * 2000;

            Console.WriteLine($"Monthly Salary: {totalSalary}");
        }
    }
}

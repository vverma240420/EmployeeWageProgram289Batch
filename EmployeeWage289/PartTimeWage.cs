using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage289
{
    internal class PartTimeWage
    {
        public static void PartTime()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;

            Console.WriteLine("Welcome to Employee Wage Computation");

            //UC3-PartTimeWage
            Random random = new Random();
            int employeeAttendance = random.Next(0, 3); //0 or 1 or 2
            if(employeeAttendance ==FULL_TIME)
            {
                Console.WriteLine("Full time employee is present");
                empHrs = 8;
            }
            else if (employeeAttendance ==PART_TIME) 
            {
                Console.WriteLine("Part time employee is present");
                empHrs = 4;

            }   
            else 
            {
                Console.WriteLine("Employee is Absent");
                //empHrs = 0;
                
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            //  Console.WriteLine("Employee wage :" + empWage);   old way
            Console.WriteLine("Employee wage :{0}", empWage);
            Console.ReadLine();
        }
    }
}

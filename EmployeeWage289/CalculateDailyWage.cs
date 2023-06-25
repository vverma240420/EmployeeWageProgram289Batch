using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage289
{
    internal class CalculateDailyWage
    {
        public static void CalculateWage()
        {
            const int FULL_TIME = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;

            Console.WriteLine("Welcome to Employee Wage Computation");

            //UC1- EmployeeAttendance
            Random random = new Random();
            int employeeAttendance = random.Next(0, 2); //0 or 1
            if(employeeAttendance == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                //empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage:{0}", empWage);
            Console.ReadLine(); 
        }
    }
}

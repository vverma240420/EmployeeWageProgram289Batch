using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage289
{
    internal class EmployeeAttendance
    {
        public static void EmpAttendance()
        {
            int ispresent = 1;
            Console.WriteLine("Welcome to Employee Wage Computation");


            Random random = new Random();
            int employeeAttendance = random.Next(0, 2);  // 0 or 1
            if(employeeAttendance == ispresent) 
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();        }
    }
}

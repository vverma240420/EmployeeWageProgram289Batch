﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage289
{
    internal class UsingSwitchCase
    {
        public static void SwitchCase()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;

            Console.WriteLine("Welcome to Employee Wage Computation");

            //UC4- SwitchCase
            Random random = new Random();
            int employeeAttendance = random.Next(0, 3); // 0 or 1 or 2
            switch (employeeAttendance) 
            {
                case FULL_TIME:
                    Console.WriteLine("Full time employee is present");
                    empHrs = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Part time employee is present");
                    empHrs = 4;
                    break;
                  
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            //Console.WriteLine("Employee wage:"+empWage);  old way
            Console.WriteLine("Employee Wage:{0}", empWage);  //new way
            Console.ReadLine();
        }
    }
}

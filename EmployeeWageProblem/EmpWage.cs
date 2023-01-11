using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public  void ComputeEmpWage(string company, int EMP_RATE_PER_HOUR, int MONTHLY_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            Console.WriteLine("Welcome To Employee Wage Problem\n");
            int EmpWage = 0;
            int totalEmpWage = 0;
            int EmpHrs = 0;
            int totalEmpHrs = 0;
            int TotalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays < MONTHLY_WORKING_DAYS)
            {
                TotalWorkingDays++;
                {
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_FULL_TIME:
                            Console.WriteLine("EMPLOYEE IS PRESENT FULL TIME");
                            EmpHrs = 8;
                            break;
                        case IS_PART_TIME:
                            Console.WriteLine("EMPLOYEE IS  PRESENT HALF TIME");
                            EmpHrs = 4;
                            break;
                        default:
                            Console.WriteLine("EMPLOYEE IS ABSENT");
                            EmpHrs = 0;
                            break;
                    }
                    totalEmpHrs += EmpHrs;
                    Console.WriteLine("Days#:" + TotalWorkingDays + " Emp Hrs : " + EmpHrs);
                }
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("\ncompany name : " + company + " Total Emp Wage : " + totalEmpWage);
        
        }
    }
}

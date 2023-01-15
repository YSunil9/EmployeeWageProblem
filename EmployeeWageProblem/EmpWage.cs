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
        public int MONTHLY_WORKING_DAYS;
        public int MAX_HRS_IN_MONTH;
        public int EMP_RATE_PER_HOUR;
        public  string company;
        int totalEmpWage;
        public EmpWage(string company, int EMP_RATE_PER_HOUR, int MONTHLY_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.MONTHLY_WORKING_DAYS = MONTHLY_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
        }
        public  void ComputeEmpWage()
        {
            Console.WriteLine("Welcome To Employee Wage Problem\n");
            int EmpHrs = 0;
            int totalEmpHrs = 0;
            int TotalWorkingDays = 0;
            while (totalEmpHrs <= this.MAX_HRS_IN_MONTH && TotalWorkingDays < this.MONTHLY_WORKING_DAYS)
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
        public String ToString()
        {
            return "Total EmpWage For Company :" + this.company + " is:" + this.totalEmpWage;
        }
    }
}

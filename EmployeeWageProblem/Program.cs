﻿namespace EmployeeWageProblem
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Problem\n");
            int EMP_RATE_PER_HOUR = 20;
            int MONTHLY_WORKING_DAYS = 20;
            int EmpHrs = 0;
            int EmpWage = 0;
            int TotalEmpWage = 0;            
            for (int day = 0; day < MONTHLY_WORKING_DAYS; day++)
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
                EmpWage = EmpHrs * EMP_RATE_PER_HOUR;
                TotalEmpWage +=EmpWage;
                Console.WriteLine("Employee Wage is : " + EmpWage);
            }
            Console.WriteLine("Total Employee Wage is : " + TotalEmpWage);
        }
    }
}
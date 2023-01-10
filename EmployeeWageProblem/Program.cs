namespace EmployeeWageProblem
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MONTHLY_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static int ComputeEmp()
        //static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Problem\n");
            //int EMP_RATE_PER_HOUR = 20;
            //int MONTHLY_WORKING_DAYS = 20;
            //int MAX_HRS_IN_MONTH = 100;
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
                    Console.WriteLine("Days#:" + TotalWorkingDays + "Emp Hrs :" + EmpHrs);
                }
                 totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Total Emp Wage : " + totalEmpWage);
                totalEmpWage = totalEmpWage + EmpWage;
            }       
            Console.WriteLine("\nTotal Working Hours : " + totalEmpHrs + "\nTotal Employee Wage For Month : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmp();
        }
    }
}
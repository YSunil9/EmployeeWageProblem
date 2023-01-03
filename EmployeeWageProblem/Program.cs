namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Problem\n");
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT FULL TIME");
                EmpHrs = 8;
            }
            else if(empCheck == IS_PART_TIME)
            {
                Console.WriteLine("EMPLOYEE IS  PRESENT HALF TIME");
                EmpHrs = 4;
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
                EmpHrs=0;
            }
            EmpWage= EmpHrs*EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is : "+EmpWage);
        }
    }
}
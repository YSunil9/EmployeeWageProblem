namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Problem");
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
            }
        }
    }
}
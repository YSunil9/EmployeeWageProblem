namespace EmployeeWageProblem
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           EmpWage empWage = new EmpWage();
           empWage.ComputeEmpWage("Wipro", 20, 27, 165);
           empWage.ComputeEmpWage("Reliance", 18, 20, 132);
        }
    }
}
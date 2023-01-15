namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWage wipro = new EmpWage("Wipro", 20, 27, 165);
            EmpWage Reliance = new EmpWage("Reliance", 18, 20, 132);
            wipro.ComputeEmpWage();
            Console.WriteLine(wipro.ToString);
            Reliance.ComputeEmpWage();
            Console.WriteLine(Reliance.ToString);
        }
    }
}

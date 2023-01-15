namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder();
            builder.addtoArray("Wipro", 20, 27, 165);
            builder.addtoArray("Reliance", 18, 20, 132);
            builder.ComputeEmpWage();
            //EmpWage wipro = new EmpWage("Wipro", 20, 27, 165);
            //EmpWage Reliance = new EmpWage("Reliance", 18, 20, 132);
            //wipro.ComputeEmpWage();
            //Console.WriteLine(wipro.ToString);
            //Reliance.ComputeEmpWage();
            //Console.WriteLine(Reliance.ToString);
            //EmpWageBuilderObject tata = new EmpWageBuilderObject("Tata", 14, 24, 104);
            //EmpWageBuilderObject mahindra = new EmpWageBuilderObject("Mhaindra", 18, 25, 108);
            //tata.ComputionEmpWage();
            //Console.WriteLine(tata.ToString());
            //mahindra.ComputionEmpWage();
            //Console.WriteLine(mahindra.ToString());
        }
    }
}

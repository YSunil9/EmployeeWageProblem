using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Builder
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private int numberOfCompanies = 0;
        private EmpWage[] companyEmpWagearray;
        public Builder()
        {
            this.companyEmpWagearray = new EmpWage[5];
        }
        public void addtoArray(string company, int EMP_RATE_PER_HOUR, int MONTHLY_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            companyEmpWagearray[this.numberOfCompanies] = new EmpWage(company, EMP_RATE_PER_HOUR, MONTHLY_WORKING_DAYS, MAX_HRS_IN_MONTH);
            numberOfCompanies++;
        }
            public void ComputeEmpWage()
            {
                for (int i = 0; i < numberOfCompanies; i++)
                {
                    companyEmpWagearray[i].setTotalEmpWage((this.ComputeEmpWage(this.companyEmpWagearray[i])));
                    Console.WriteLine(this.companyEmpWagearray[i].companyNameAndSalary());
                }
            }
        public int ComputeEmpWage(EmpWage EmployeeWage)
        {
            int EmpHrs = 0;
            int totalEmpHrs = 0;
            int TotalWorkingDays = 0;
            while (totalEmpHrs <= EmployeeWage.MAX_HRS_IN_MONTH && TotalWorkingDays < EmployeeWage.MONTHLY_WORKING_DAYS)
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
            return totalEmpHrs * EmployeeWage.EMP_RATE_PER_HOUR;
        }           
    }
}
public class EmpWage
{

    public int MONTHLY_WORKING_DAYS;
    public int MAX_HRS_IN_MONTH;
    public int EMP_RATE_PER_HOUR, totalEmpWage;
    public string company;

    public EmpWage(string company, int EMP_RATE_PER_HOUR, int MONTHLY_WORKING_DAYS, int MAX_HRS_IN_MONTH)
    {
        this.company = company;
        this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
        this.MONTHLY_WORKING_DAYS = MONTHLY_WORKING_DAYS;
        this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
        int totalEmpWage;
    }
    public void setTotalEmpWage(int totalEmpWage)
    {
        this.totalEmpWage = totalEmpWage;
    }
    public string companyNameAndSalary()
    {
        return "Company Name : " + this.company + "\nEmployerSalary : " + this.totalEmpWage;
    }
}
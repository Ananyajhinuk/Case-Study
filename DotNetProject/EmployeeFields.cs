using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    abstract class EmployeeFields
    {
        //    EmployeeId, Employee Name, Address, City, Department,

        public int EmployeeId;
        public string Name;
        public string Address;
        public string City;
        public string Department;
        public EmployeeFields(int employeeId, string name, string address, string city, string department)
        {
            EmployeeId = employeeId;
            Name = name;
            Address = address;
            City = city;
            Department = department;

        }

        public double Salary { get; set; }
        public EmployeeFields() { }
        public EmployeeFields(double s)
        {
            this.Salary = s;
        }
        public abstract double GetSalary();

        static void Main(string[] args)
        {
            EmployeeFields newEmp = null;
            int n = 0;
            while (n != 3)
            {
                Console.WriteLine("\nPress 1 for contract employee");
                Console.WriteLine("Press 2 for permanent employee");
                Console.WriteLine("Press 3 for Exit");
                Console.Write("Your choice: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                        newEmp = new ContractEmployee();
                        Console.WriteLine("Enter the EmployeeId : ");
                        newEmp.EmployeeId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name : ");
                        newEmp.Name = Console.ReadLine();
                        Console.WriteLine("Enter the address : ");
                        newEmp.Address = Console.ReadLine();
                        Console.WriteLine("Enter City : ");
                        newEmp.City = Console.ReadLine();
                        Console.WriteLine("Enter department : ");
                        newEmp.Department = Console.ReadLine();
                        Console.Write("Enter the salary: ");
                        newEmp.Salary = double.Parse(Console.ReadLine());
                        Console.Write("Enter the perks: ");
                        ((ContractEmployee)newEmp).Perks = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nContract employee");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Employee ID : {0}", newEmp.EmployeeId);
                        Console.WriteLine("Employee Name : {0}", newEmp.Name);
                        Console.WriteLine("Employee address : {0}", newEmp.Address);
                        Console.WriteLine("Employee city : {0}", newEmp.City);
                        Console.WriteLine("Employee department : {0}", newEmp.Department);
                        Console.WriteLine("Salary without perks {0}", newEmp.Salary.ToString());
                        Console.WriteLine("Perks: {0}", ((ContractEmployee)newEmp).Perks.ToString());
                        Console.WriteLine("Salary with perks {0}", newEmp.GetSalary().ToString());
                    }
                    break;
                    case 2:
                        {
                        newEmp = new PermanentEmployee();
                        Console.WriteLine("Enter the EmployeeId : ");
                        newEmp.EmployeeId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name : ");
                        newEmp.Name = Console.ReadLine();
                        Console.WriteLine("Enter the address : ");
                        newEmp.Address = Console.ReadLine();
                        Console.WriteLine("Enter City : ");
                        newEmp.City = Console.ReadLine();
                        Console.WriteLine("Enter department : ");
                        newEmp.Department = Console.ReadLine();
                        Console.Write("Enter salary: ");
                        newEmp.Salary = double.Parse(Console.ReadLine());
                        Console.Write("Enter the number of leaves: ");
                        ((PermanentEmployee)newEmp).NoOfLeaves = int.Parse(Console.ReadLine());
                        Console.Write("Enter the providend fund: ");
                        ((PermanentEmployee)newEmp).ProvidendFund = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nPermanent employee");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Employee ID : {0}", newEmp.EmployeeId);
                        Console.WriteLine("Employee Name : {0}", newEmp.Name);
                        Console.WriteLine("Employee address : {0}", newEmp.Address);
                        Console.WriteLine("Employee city : {0}", newEmp.City);
                        Console.WriteLine("Employee department : {0}", newEmp.Department);
                        Console.WriteLine("Salary with providend fund : {0}", newEmp.Salary.ToString());
                        Console.WriteLine("No of leaves : {0}", ((PermanentEmployee)newEmp).NoOfLeaves);
                        Console.WriteLine("Providend fund : {0}", ((PermanentEmployee)newEmp).ProvidendFund.ToString());
                        Console.WriteLine("Salary without providend fund : {0}", newEmp.GetSalary().ToString());
                    }
                    break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Wrong menu item. Try again.");
                    break;
                }
            }
        }
        class ContractEmployee : EmployeeFields
        {
            public double Perks { get; set; }
            public ContractEmployee() { }
            public ContractEmployee(double p, double s)
                : base(s)
            {
                this.Perks = p;
            }
            public override double GetSalary()
            {
                return Salary + Perks;
            }
        }
        class PermanentEmployee : EmployeeFields
        {
            public int NoOfLeaves { get; set; }
            public double ProvidendFund { get; set; }
            public PermanentEmployee() { }
            public PermanentEmployee(int noOfLeaves, double providendFund, double salary)
                : base(salary)
            {
                this.NoOfLeaves = noOfLeaves;
                this.ProvidendFund = providendFund;
            }
            public override double GetSalary()
            {
                return Salary - ProvidendFund;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    internal class Employee
    {
        int EmployeeId;
        string EmployeeName = "";
        string Address = "";
        string City = "";
        string Department = "";
        decimal Salary;

        public int setEmployeeId
        {
            get { return EmployeeId; }  
            set { EmployeeId = value; }
        }

        public string setEmployeeName
        {
            get { return setEmployeeName; }
            set { EmployeeName = value; }
        }

        public string setAddress
        {
            get { return Address; }
            set { Address = value; }
        }

        public string setCity
        {
            get { return City; }
            set { City = value; }
        }

        public string setDepartment
        {
            get { return Department; }
            set { Department = value; }
        }

        public decimal setSalary
        {
            set { Salary = value; }
            get { return Salary; }
        }
        
        //public void toString()
        //{
        //    Console.Write("Id -> " + this.EmployeeId + "Name -> " + this.EmployeeName + "Address -> " + this.Address + "City -> " + this.City + "Department -> " + this.Department + "Salary -> " + this.Salary);
        //}


        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            Employee obj = new Employee();

            int empId;
            for(int i=0; i<1; i++)
            {
                Console.WriteLine("Employee Id:");
                obj.EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Employee Name:");
                obj.EmployeeName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Address:");
                obj.Address =Convert.ToString(Console.ReadLine());
                Console.WriteLine("City:");
                obj.City = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Department:");
                obj.Department =Convert.ToString(Console.ReadLine());
                Console.WriteLine("Salary:");
                obj.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("/////////////////////////");

            }
            for(int i=0; i<1; i++)
            {
                Console.WriteLine("Employee id:");
                Console.WriteLine(obj.EmployeeId);
                Console.WriteLine("Employee Name:");
                Console.WriteLine(obj.EmployeeName);
                Console.WriteLine("Address:");
                Console.WriteLine(obj.Address);
                Console.WriteLine("City:");
                Console.WriteLine(obj.City);
                Console.WriteLine("Department:");
                Console.WriteLine(obj.Department);
                Console.WriteLine("Salary:");
                Console.WriteLine(obj.Salary);
                Console.WriteLine("///////////////////////");
            }   

        }
    }
}

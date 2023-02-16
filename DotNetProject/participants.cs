using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    internal class participants
    {
        int EmpId;
        String Name;
        String CompanyName;
        decimal FoundationMarks;
        decimal WebBasicMarks;
        decimal DotNetMarks;
        decimal TotalMarks = 300;
        decimal ObtainedMarks;
        decimal Percentage;

        public int empId {
            get { return EmpId; }
            set { EmpId = value; }
        }
        public String name
        {
            get { return Name; }
            set { Name = value; }
        }
        public String companyName
        {
            get { return CompanyName; }
            set { CompanyName = value; }
        }
        public decimal foundationMarks
        {
            get { return FoundationMarks; }
            set { FoundationMarks = value; }
        }
        public decimal webBasicMarks
        {
            get { return WebBasicMarks; }
            set { WebBasicMarks = value; }
        }
        public decimal dotNetMarks
        {
            get { return DotNetMarks; }
            set { DotNetMarks = value; }
        }
        public decimal totalMarks
        {
            get { return TotalMarks; }
            set { TotalMarks = value; }
        }
        public decimal obtainedMarks
        {
            get { return ObtainedMarks; }
            set { ObtainedMarks = value; }
        }
        public decimal percentage
        {
            get { return Percentage; }
            set { Percentage = value; }
        }
        public decimal calculateTotalMarks()
        {
            return foundationMarks + webBasicMarks+ dotNetMarks;
        }

        public decimal calculatePercentage() {
            return calculateTotalMarks() / totalMarks * 100;
        }

        static void Main(String[] args)
        {
            participants obj = new participants();
            Console.Write("Enter Foundation Marks : ");
            try
            {
                obj.foundationMarks = Convert.ToDecimal(Console.ReadLine());
                if(obj.foundationMarks > 100)
                {
                    throw new Exception("Wrong marks");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Enter WebBasic Marks : ");
            try
            {
                obj.webBasicMarks = Convert.ToDecimal(Console.ReadLine());
                if(obj.webBasicMarks> 100)
                {
                    throw new Exception("Wrong marks");
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Enter DotNet Marks : ");
            try
            {
                obj.dotNetMarks= Convert.ToDecimal(Console.ReadLine());
                if(obj.dotNetMarks > 100)
                {
                    throw new Exception("Wrong marks");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("Press 1 to get Obtained marks");
            Console.WriteLine("Press 2 to get Percentage");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    Console.Write("Total Marks : ");
                    Console.WriteLine(obj.calculateTotalMarks());
                    break;
                case 2:
                    Console.Write("Percentage : ");
                    Console.WriteLine(obj.calculatePercentage());
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}

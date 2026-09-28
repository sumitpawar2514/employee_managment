using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_managment
{
    internal class Developer:Employee,Operation
    {
        public double Allowance { get; set; }

        public Developer(int id,string name, string city, double salary,double allowance):base(id,name,salary,city)
        {
            Allowance = allowance;
        }
        public override void Display()
        {
            Console.WriteLine("----- Developers Details ------");
            Console.WriteLine("ID :  " + Id);
            Console.WriteLine("NAME : " + Name);
            Console.WriteLine("CITY : " + City);
            Console.WriteLine("SALARY : " + Salary);
            Console.WriteLine("ALLOWANCE : " + Allowance);
            Console.WriteLine("TOTAL SALARY : " + CalculateSalary());
        }
        public override double CalculateSalary()
        {
            return Salary + Allowance;
        }
    }
}

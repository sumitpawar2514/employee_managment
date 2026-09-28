using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_managment
{
    internal class Manager :Employee,Operation //multilevel inheritance using interface
    {
        public double Bonus { get; set; }

        public Manager(int id,string name,string city,double salary,double bonus):base(id,name,salary,city)
        {
            Bonus = bonus;
        }
        public override void Display()
        {
            Console.WriteLine("----Manager Details-----");
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("NAME : " + Name);
            Console.WriteLine("CITY : " + City);
            Console.WriteLine("SALARY : " + Salary);
            Console.WriteLine("BONUS :  " + Bonus);
            Console.WriteLine("TOTAL SALARY :  " + CalculateSalary());
        }
        public override double CalculateSalary()
        {
            return Salary + Bonus;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_managment
{
    internal class Employee //base class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string City { get; set; }

        public Employee(int id,string name, double salary,string city)
        {
            Id = id;
            Name = name;
            Salary = salary;
            City = city;
        }
        public virtual void Display()
        {
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("NAME : " + Name);
            Console.WriteLine("CITY : " + City);
            Console.WriteLine("SALARY : " + Salary);
        }
        public virtual double CalculateSalary()
        {
            return Salary;
        }
    }
}

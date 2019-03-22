using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary;
        //Create a class called Employee with the following properties:
        //Salary - protected, double???????????

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} has salary {GetSalary()}.");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}

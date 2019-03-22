using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        private double Bonus;
        //Add class Manager that inherits from Employee and has a new property called Bonus - double, private

        public Manager(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 500;
            Role = Role.Manager;
        }
        //Create a constructor that sets all properties except Bonus

        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }
        //Create a method called AddBonus that adds bonus to the Bonus property

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }
        //Override the method GetSalary to return the Salary + Bonus

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        private double SuccessSaleRevenue;

        public SalesPerson(string lastName, string firstName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 500;
            Role = Role.Sales;
        }
        //Create a SalesPerson class that inherits from Employee and has the following properties:
        //    SuccessSaleRevenue double, private
        //    The salary is by default 500 and role is default Sales
        //Create constructor that sets all the properties

        public void AddSuccessRevenue(double successSaleRevenue)
        {
            SuccessSaleRevenue = successSaleRevenue;
        }
        //Create a method called AddSuccessRevenue that will get a number and set the SuccessSaleRevenue to that value

        public override double GetSalary()
        {
            if(SuccessSaleRevenue <= 2000)
            {
                return base.GetSalary() + 500;
            }
            else if(SuccessSaleRevenue <= 5000)
            {
                return base.GetSalary() + 1000;
            }
            else
            {
                return base.GetSalary() + 1500;
            }
        }
        //Override the GetSalary method to return the value of the salary plus bonus that is calculated by the SuccessSaleRevenue.
        //    If less or equal to 2000 then add 500 bonus
        //    If larger than 2000 but less or equal than 500 then add 1000 bonus
        //    If larger than 5000 add 1500 bonus

    }
}

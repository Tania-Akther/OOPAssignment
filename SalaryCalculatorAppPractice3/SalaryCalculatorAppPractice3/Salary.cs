using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class Salary
    {
        public string employeeName;
        public double basicAmount;
        public double houseRentPercent;
        public double medicalAllowancePercent;

        public string GetSalary()
        {
            double salary = basicAmount + (basicAmount * houseRentPercent / 100) +
                            (basicAmount * medicalAllowancePercent / 100);

            string message = employeeName + " your salary is: " + salary;

            return message;
        }
    }
}

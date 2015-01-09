using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class EmployeeSalary
    {
        public string name;
        public double basicSalary;
        public double houseRent;
        public double medicalAllowance;

        public double CalculateTotalSalary()
        {
            double result;
            result = basicSalary + HouseRentPercent() + MedicalAllowancePercent();
            return result;
        }

        private double MedicalAllowancePercent()
        {
            return basicSalary*(medicalAllowance / 100);
        }

        private double HouseRentPercent()
        {
            return basicSalary * (houseRent / 100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        EmployeeSalary aEmployeeSalary = new EmployeeSalary();
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            aEmployeeSalary.name = employeeNameTextBox.Text;
            aEmployeeSalary.basicSalary = Convert.ToDouble(basicAmountTextBox.Text);
            aEmployeeSalary.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            aEmployeeSalary.medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            double totalSalary = aEmployeeSalary.CalculateTotalSalary();
            MessageBox.Show(aEmployeeSalary.name + " Your Total Salary is : " + totalSalary);
        }
    }
}

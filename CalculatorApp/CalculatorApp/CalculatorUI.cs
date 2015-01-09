using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        Calculator aCalculator = new Calculator();
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double getResult = aCalculator.Add(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text));
            resultTextBox.Text = getResult.ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            double getResult = aCalculator.Subtract(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text));

            resultTextBox.Text = getResult.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double getResult = aCalculator.Multiply(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text));

            resultTextBox.Text = getResult.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double getResult = aCalculator.Divide(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text));

            resultTextBox.Text = getResult.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Text = string.Empty;
            secondNumberTextBox.Text = string.Empty;
            resultTextBox.Text = string.Empty;
        }
        
    }
}

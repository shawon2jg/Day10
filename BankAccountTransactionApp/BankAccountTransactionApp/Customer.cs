using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTransactionApp
{
    class Customer
    {
        public string accountNumber;
        public string name;
        public double amount;
        double sum = 0;

        public double GivenDeposit(double amount)
        {
            sum += amount;
            return sum;
        }

        public double GetWithdraw(double amount)
        {
            sum -= amount;
            return sum;
        }

        public string GetReport()
        {
            return name + ", Your Account No is: " + accountNumber + " & Balance is: " + sum;
        }
    }
}

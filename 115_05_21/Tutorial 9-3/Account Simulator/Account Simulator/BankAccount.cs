using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }
        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }

        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else if (amount > 0)
            {
                MessageBox.Show("Insufficient funds. Withdrawal denied.");
            }
            else
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a positive value.");
            }
        }
    }
}
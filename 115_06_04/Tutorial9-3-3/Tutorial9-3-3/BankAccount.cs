using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial9_3_3
{
    public class BankAccount
    {
        private decimal balance;
        private string name;
        private string accountNumber;
        public BankAccount(string accountNumber, string name, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            balance = initialBalance;
        }
        public decimal Balance
        {
            get { return balance; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                balance = 0;
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
                MessageBox.Show("餘額不足，無法提出，交易被拒。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("提款金額無效。請輸入正數。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


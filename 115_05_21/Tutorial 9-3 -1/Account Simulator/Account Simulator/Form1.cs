using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        private BankAccount account;
      


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //balanceLabel.Text = account.Balance.ToString("C");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                account.Deposit(amount);
                balanceLabel.Text = account.AccountNumber + "\n"
                                    + account.Name + "\n"
                                    + account.Balance.ToString("C");
                depositTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid deposit amount. Please enter a valid number.");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                account.Withdraw(amount);
                balanceLabel.Text = account.Balance.ToString("C");
                withdrawTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a valid number.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void accountNumbertextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(balancetextBox.Text, out  amount))
            {
               string accountNumber = accountNumbertextBox.Text;
               string name = nametextBox.Text;
               account = new BankAccount(accountNumbertextBox.Text, nametextBox.Text, amount);
               balanceLabel.Text = account.AccountNumber + "\n"
                                    + account. Name + "\n"
                                    + account.Balance.ToString("C");

                balancetextBox.Clear();
                nametextBox.Clear();
                accountNumbertextBox.Clear();

                depositGroupBox.Visible = true;
                withdrawGroupBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid initial balance. Please enter a valid number.");
            }
        }
    }
}
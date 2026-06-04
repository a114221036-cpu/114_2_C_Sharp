using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial9_3_3
{
    public partial class Form1 : Form
    {
        // 使用 List<BankAccount> 來管理多個銀行帳戶
        private List<BankAccount> accounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
          OpenAccountForm openAccountForm = new OpenAccountForm(accounts);
          openAccountForm.ShowDialog();

            this.label1.Text = $"已開戶用戶數: {this.accounts.Count}";

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(accounts);
            depositForm.ShowDialog();
        }
    }
}

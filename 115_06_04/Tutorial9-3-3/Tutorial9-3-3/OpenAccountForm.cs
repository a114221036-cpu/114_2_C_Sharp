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
    public partial class OpenAccountForm : Form
    {

        private List<BankAccount> bankaccounts;
        public OpenAccountForm(List<BankAccount> accounts)
        {
            InitializeComponent();
            this.bankaccounts = accounts;
        }

        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccount.Text.Trim();
            string accountName = txtName.Text.Trim();
            decimal initialBalance;

            if (decimal.TryParse(txtInitial.Text.Trim(), out initialBalance))
            {
                BankAccount newAccount = new BankAccount(accountNumber, accountName, initialBalance);
                bankaccounts.Add(newAccount);
                MessageBox.Show("帳戶建立成功！");
                // 在介面上的結果標籤中顯示剛建立的帳戶資訊（僅更新 UI）
                if (this.lblResult != null)
                {
                    this.lblResult.Text = string.Format("帳號：{0}\r\n姓名：{1}\r\n餘額：{2}",
                        newAccount.AccountNumber,
                        newAccount.Name,
                        newAccount.Balance.ToString("C"));
                }

            }
            else
            {
                MessageBox.Show("請輸入有效的開戶金額！");
            }
        }

        private void OpenAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

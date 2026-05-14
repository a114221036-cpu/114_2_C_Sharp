using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void tossButton_Click(object sender, EventArgs e)
        {
            Coin myCoin = new Coin();  //創建一個Coin類的實例

            outputListBox.Items.Clear (); //清除列表框中的現有項目

            //投擲硬幣五次的事件處理
            for (int i = 0; i < 5; i++)
            {
                myCoin.Toss(); //投擲硬幣

                outputListBox.Items.Add(myCoin.GetSideUp()); //將硬幣的正面或反面添加到列表框中
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

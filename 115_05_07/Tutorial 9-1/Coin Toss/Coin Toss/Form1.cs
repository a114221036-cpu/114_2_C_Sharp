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
            // 說明：當使用者按下「擲五次」按鈕時，應產生五次擲硬幣的結果並顯示於上方清單。
            // 目前此事件處理器保留為空，實際擲硬幣邏輯可在此處實作。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 說明：按下此按鈕後關閉視窗並結束程式。
            this.Close();
        }
    }
}

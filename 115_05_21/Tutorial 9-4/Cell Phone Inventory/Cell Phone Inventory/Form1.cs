using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // 儲存 CellPhone 物件的清單
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData 方法接受一個 CellPhone 物件作為參數。
        // 此方法會將使用者輸入的資料指派給該物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            // Temporary variable to hold the price.
            // 暫存變數，用來存放價格
            decimal price;

            // 取得手機品牌
            phone.Brand = brandTextBox.Text;

            // 取得手機型號
            phone.Model = modelTextBox.Text;

            // 取得手機價格，並嘗試轉換為 decimal
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // 顯示錯誤訊息（價格無效）
                MessageBox.Show("價格格式不正確");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone Phone = new CellPhone(); // 建立新的 CellPhone 物件
            GetPhoneData(Phone); // 從使用者輸入取得資料並指派給 newPhone
            phoneList.Add(Phone); // 將 newPhone 加入清單

            // 將手機資訊顯示在 ListBox 中
            phoneListBox.Items.Add($"{Phone.Brand} {Phone.Model} ");

            // 清空輸入欄位
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            // 將焦點設回品牌輸入框，方便使用者繼續輸入下一筆資料
            brandTextBox.Focus();

        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox.SelectedIndex;

            MessageBox.Show(phoneList[index].Price.ToString("C"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void listGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}

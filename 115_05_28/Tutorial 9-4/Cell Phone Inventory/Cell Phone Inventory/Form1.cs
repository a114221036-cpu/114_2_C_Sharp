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
        // 這個方法會將使用者輸入的資料指派給該物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            // 暫存價格的變數。
            decimal price;

            // 取得手機的品牌。
            phone.Brand = brandTextBox.Text;

            // 取得手機的型號。
            phone.Model = modelTextBox.Text;

            // 取得手機的價格。
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // 顯示錯誤訊息。
                MessageBox.Show("Invalid price");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone myphone = new CellPhone();
            GetPhoneData(myphone);
            phoneList.Add(myphone);
            phoneListBox.Items.Add(myphone.Brand + " " + myphone.Model);

            // 清除輸入欄位。
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            // 將焦點設定回品牌輸入欄位。
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox.SelectedIndex;
            if (index >= 0 && index < phoneList.Count)
            {
                CellPhone selectedPhone = phoneList[index];
                MessageBox.Show("價格: " + selectedPhone.Price.ToString("C"));
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}

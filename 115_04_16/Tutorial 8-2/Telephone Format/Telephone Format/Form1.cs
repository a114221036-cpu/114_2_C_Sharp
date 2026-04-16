using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidNumber方法接受一個字符串
        // 如果字符串敷好含捄10個數字，會返回true；
        // 否則返回false。
        private bool IsValidNumber(string str)
        {
            // 检查字符串是否提供
            // 检查是否兩好是10個數字
            if (str == null || str.Length != 10)
            {
                return false;
            }
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return false;
        }

        // TelephoneFormat方法透過參照接受一個字符串
        // 並將其格式化為電話號碼（例如(123) 456-7890）。
        private void TelephoneFormat(ref string str)
        {
           // 实现电话号码格式化
           //string part1 = str.Substring(0, 3);
           //string part2 = str.Substring(3, 3);
           // string part3 = str.Substring(6, 4);


           //str = "(" + part1 + ") " + part2 + "-" + part3;

            str =str.Insert(0, "(")    //在字串開頭插入左括號(0222368225
                    .Insert(3, ") ")   //在第3個位置插入右括號和空格(02) 22368225
                    .Insert(9, "-");   //在第8個位置插入連字符 (02) 2236-8225
        }
        //格式化按鈕的點擊事件處理方法
        private void formatButton_Click(object sender, EventArgs e)
        {
            // 处理格式化按鈕的点击事件
            string input = numberTextBox.Text;

            if (IsValidNumber(input))
            {
                TelephoneFormat(ref input);
                MessageBox.Show("格式化的電話號碼: " + input);
            }
            else
            {
                MessageBox.Show("請輸入有效的10位數字。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉窗体。
            this.Close();
        }
    }
}

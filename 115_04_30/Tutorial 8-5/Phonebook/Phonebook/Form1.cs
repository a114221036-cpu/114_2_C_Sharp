using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        // Field to hold a list of PhoneBookEntry objects.
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        // 讀取指定路徑的檔案，將每一行解析為 PhoneBookEntry 並加入 phoneList
        // 預期每行格式為: 姓名,電話
        private void ReadFile(string path)
        {
            phoneList.Clear();
            try
            {
                using (StreamReader inputFile = File.OpenText(path))
                {
                    string line;
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            // 忽略空白或空行
                            continue;
                        }

                        // 以第一個逗號為分隔，避免姓名中若包含逗號造成問題
                        string[] parts = line.Split(new[] { ',' }, 2);
                        if (parts.Length < 2)
                        {
                            // 若行格式不正確，略過該行
                            continue;
                        }

                        PhoneBookEntry entry = new PhoneBookEntry();
                        entry.name = parts[0].Trim();
                        entry.phone = parts[1].Trim();
                        phoneList.Add(entry);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("找不到檔案：" + path + "。請確認檔案已存在於執行目錄或提供正確路徑。", "讀取檔案錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取檔案時發生錯誤：" + ex.Message, "讀取檔案錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // The DisplayNames method displays the list of names
        // in the namesListBox control.
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile("PhoneList.txt");
            DisplayNames();

        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;
            if(index != -1)
            {
                string phome = phoneList[index].phone;
                selectedPhoneDescriptionLabel.Text = "電話號碼：";
                phoneLabel.Text = phome;

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void selectedPhoneDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 從指定的文字檔讀取分數，並將每一筆分數加入到傳入的列表中
        private void ReadScores(List<int> scoresList)
        {
            string filePath = "TestScores.txt";
            try
            {
                // 嘗試以 StreamReader 開啟檔案，讀取每一行並解析成整數後加入列表
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        // 忽略空行並解析整數
                        line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        if (int.TryParse(line.Trim(), out int score))
                        {
                            scoresList.Add(score);
                        }
                        else
                        {
                            // 若該行無法解析為整數，略過（或可記錄）
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 若發生例外，顯示中文錯誤訊息
                MessageBox.Show("讀取檔案時發生錯誤： " + ex.Message);
            }
        }

        // 將分數列表顯示在 ListBox 中
        private void DisplayScores(List<int> scoresList)
        {

            testScoresListBox.Items.Clear();
            foreach (int s in scoresList)
            {
                testScoresListBox.Items.Add(s.ToString());
            }
        }

        // 計算並回傳平均分數
        private double Average(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0.0;

            double sum = 0;
            foreach (int s in scoresList)
                sum += s;

            return sum / scoresList.Count;
        }

        // 計算高於平均的分數數量
        private int AboveAverage(List<int> scoresList, double average)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0;

            int count = 0;
            foreach (int s in scoresList)
            {
                if (s > average)
                    count++;
            }
            return count;
        }

        // 計算低於平均的分數數量
        private int BelowAverage(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0;

            // 若要比對低於平均，需要先計算平均
            double avg = Average(scoresList);
            int count = 0;
            foreach (int s in scoresList)
            {
                if (s < avg)
                    count++;
            }
            return count;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // 儲存平均分數
            int numAboveAverage;    // 高於平均的分數數量
            int numBelowAverage;    // 低於平均的分數數量

            // 建立一個 List 用來存放分數
            List<int> scoresList = new List<int>();

            // 從檔案讀取分數到列表
            ReadScores(scoresList);

            // 顯示分數列表
            DisplayScores(scoresList);

            // 計算並顯示平均分數
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // 顯示高於平均的分數數量
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // 顯示低於平均的分數數量
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        // 新增：搜尋按鈕事件處理器
        // 功能：從 searchTextBox 取得使用者輸入的分數（預期為整數），
        // 並在 testScoresListBox 的項目中搜尋第一個相等的分數。
        // 搜尋成功：在 searchResultLabel 顯示所在位置（以 1 為起始，格式為 "位置：n"）。
        // 搜尋失敗：在 searchResultLabel 顯示 "分數不存在"。
        // 注意：此處僅使用 ListBox 中目前顯示的項目進行搜尋，不會讀取檔案或重設列表。
        private void searchButton_Click(object sender, EventArgs e)
        {
            // 取得輸入並嘗試解析為整數
            string input = searchTextBox.Text.Trim();
            int target;
            if (!int.TryParse(input, out target))
            {
                // 輸入無法解析為整數，視為查無此分數
                searchResultLabel.Text = "分數不存在";
                return;
            }

            // 在 ListBox 項目中逐一比對
            for (int i = 0; i < testScoresListBox.Items.Count; i++)
            {
                // 項目可能是字串或數值，先以字串形式取得再解析
                string itemText = testScoresListBox.Items[i].ToString();
                int value;
                if (int.TryParse(itemText, out value))
                {
                    if (value == target)
                    {
                        // 找到，顯示位置（使用 1-based 編號以符合一般使用者直覺）
                        searchResultLabel.Text = "位置：" + (i + 1).ToString();
                        return;
                    }
                }
            }

            // 若迴圈結束表示未找到相符的分數
            searchResultLabel.Text = "分數不存在";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void searchResultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

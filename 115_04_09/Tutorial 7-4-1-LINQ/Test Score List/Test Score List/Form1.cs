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

        // 內部類別：封裝學號與分數
        private class StudentScore
        {
            public string Id { get; set; }
            public int Score { get; set; }
        }

        // 從檔案讀取學號與分數（每行格式："學號 分數"），並加入到傳入的列表中
        private void ReadScores(List<StudentScore> scoresList)
        {
            string filePath = "TestScores.txt";
            try
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        // 以空白或 TAB 分割，第一個欄位視為學號，最後一個欄位視為分數
                        string[] parts = line.Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length < 2)
                            continue; // 格式不正確，跳過

                        string id = parts[0];
                        string scoreText = parts[parts.Length - 1];
                        if (int.TryParse(scoreText, out int score))
                        {
                            scoresList.Add(new StudentScore { Id = id, Score = score });
                        }
                        else
                        {
                            // 分數解析失敗，略過該行
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 顯示中文錯誤訊息
                MessageBox.Show("讀取檔案時發生錯誤： " + ex.Message);
            }
        }

        // 顯示學號與分數於 ListBox（格式："學號 分數"）
        private void DisplayScores(List<StudentScore> scoresList)
        {
            testScoresListBox.Items.Clear();
            foreach (var e in scoresList)
            {
                testScoresListBox.Items.Add(e.Id + " " + e.Score.ToString());
            }
        }

        // 計算學生成績平均值（針對 Score 欄位）
        private double Average(List<StudentScore> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0.0;

            // 使用 LINQ 查詢語法選取所有分數，然後呼叫 Average() 計算平均
            var scores = from s in scoresList
                         select s.Score;

            return scores.Average();
        }

        // 計算大於平均的數量
        private int AboveAverage(List<StudentScore> scoresList, double average)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0;

            // 使用 LINQ 查詢語法過濾出高於平均的項目，並計算數量
            var query = from s in scoresList
                        where s.Score > average
                        select s;

            return query.Count();
        }

        // 計算小於平均的數量
        private int BelowAverage(List<StudentScore> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0;

            double avg = Average(scoresList);

            // 使用 LINQ 查詢語法過濾出低於平均的項目，並計算數量
            var query = from s in scoresList
                        where s.Score < avg
                        select s;

            return query.Count();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // 儲存平均分數
            int numAboveAverage;    // 高於平均的分數數量
            int numBelowAverage;    // 低於平均的分數數量

            // 建立 List 以存放學號與分數
            List<StudentScore> scoresList = new List<StudentScore>();

            // 從檔案讀取
            ReadScores(scoresList);

            // 顯示於 ListBox（學號 分數）
            DisplayScores(scoresList);

            // 計算並顯示平均
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // 計算並顯示高於平均與低於平均數量
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        // 搜尋按鈕事件處理器（搜尋 ListBox 中的分數，ListBox 每項格式為 "學號 分數"）
        private void searchButton_Click(object sender, EventArgs e)
        {
            // 以查詢語法 (LINQ query syntax) 找出所有符合目標分數的項目
            string input = searchTextBox.Text.Trim();
            if (!int.TryParse(input, out int target))
            {
                searchResultLabel.Text = "分數不存在";
                return;
            }

            // 使用 Enumerable.Range 與 LINQ 查詢語法來建立索引序列並解析每一項
            var matches = (from i in Enumerable.Range(0, testScoresListBox.Items.Count)
                           let itemText = testScoresListBox.Items[i].ToString()
                           let parsed = ParseStudentScore(itemText)
                           where parsed != null && parsed.Score == target
                           select new { Index = i + 1, Student = parsed }).ToList();

            if (matches.Count == 0)
            {
                searchResultLabel.Text = "分數不存在";
                return;
            }

            // 將所有符合的項目組成顯示字串（每項包含位置與學號）
            StringBuilder sb = new StringBuilder();
            sb.Append("找到：");
            bool first = true;
            foreach (var m in matches)
            {
                if (!first)
                    sb.Append("、");
                sb.AppendFormat("位置：{0} ({1})", m.Index, m.Student.Id);
                first = false;
            }

            searchResultLabel.Text = sb.ToString();
        }

        // 從 ListBox 的顯示文字解析出 StudentScore（格式預期為 "學號 分數"），解析失敗回傳 null
        private StudentScore ParseStudentScore(string itemText)
        {
            if (string.IsNullOrWhiteSpace(itemText))
                return null;

            string[] parts = itemText.Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
                return null;

            string id = parts[0];
            string scoreText = parts[parts.Length - 1];
            if (int.TryParse(scoreText, out int score))
            {
                return new StudentScore { Id = id, Score = score };
            }
            return null;
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

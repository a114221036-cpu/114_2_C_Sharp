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
using System.Linq.Expressions;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Average method accepts an int array argument
        // and returns the Average of the values in the array.

        private double Average(int[] sArray)
        {
            if (sArray == null || sArray.Length == 0)
            {
                return 0.0;
            }

            // 使用 LINQ 查詢語法來建立可列舉集合，然後呼叫 Average()
            var query = from s in sArray
                        select s;

            return query.Average();

        }

        // Highest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最大值。
        private int Highest(int[] sArray )
        {
            if (sArray == null || sArray.Length == 0)
                return 0;

            // 使用 LINQ 查詢語法取得最大值
            var query = from s in sArray
                        select s;

            return query.Max();

        }

        // Lowest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最小值。
        private int Lowest(int[] sArray )
        {
            if (sArray == null || sArray.Length == 0)
                return 0;

            // 使用 LINQ 查詢語法取得最小值
            var query = from s in sArray
                        select s;

            return query.Min();
        }

        private int getFileScoreCount()
        {
            int count = 0;
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("TestScores.txt");
                while (!inputFile.EndOfStream)
                {
                    inputFile.ReadLine();
                    count++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count;
        }



        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 讀取檔案每一行，格式: "學號" 空白 "分數」，例如: A1142210550 54
            var scoresList = new System.Collections.Generic.List<int>();
            testScoresListBox.Items.Clear();

            try
            {
                using (var inputFile = File.OpenText("TestScores.txt"))
                {
                    string line;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;
                        // 以任意空白字元分割 (支援多個空白或 tab)
                        var parts = line.Trim().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length < 2)
                            continue;
                        var id = parts[0];
                        int score;
                        if (!int.TryParse(parts[1], out score))
                            continue;

                        scoresList.Add(score);
                        // 在 ListBox 上顯示: "學號 分數"
                        testScoresListBox.Items.Add(id + " " + score);
                    }
                }

                // 在清單最上方插入學生人數
                testScoresListBox.Items.Insert(0, "學生人數 : " + scoresList.Count + "人");

                if (scoresList.Count > 0)
                {
                    var scores = scoresList.ToArray();
                    averageScoreLabel.Text = Average(scores).ToString("n1");
                    highScoreLabel.Text = Highest(scores).ToString();
                    lowScoreLabel.Text = Lowest(scores).ToString();
                }
                else
                {
                    averageScoreLabel.Text = string.Empty;
                    highScoreLabel.Text = string.Empty;
                    lowScoreLabel.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

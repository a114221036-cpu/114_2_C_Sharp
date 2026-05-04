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

namespace CSV_Reader
{
    struct Student
    {
        public string ClassName; // 班級
        public string Id; // 學號
        public string Name; // 姓名
        public int[] Scores; // 分數陣列，包含 5 科分數
    }
    // 此表單類別負責讀取本專案根目錄下的 "Grades.csv" 檔案，
    // 將每一列的成績解析為整數並計算平均，然後將結果顯示在 ListBox 中。
    public partial class Form1 : Form
    {
        private List<Student> gradeBook = new List<Student>(); // 儲存學生資料的清單
        // 建構子：初始化視窗元件
        public Form1()
        {
            InitializeComponent();
        }

        // 按鈕事件：當使用者按下「取得成績」按鈕時呼叫
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 使用 StreamReader 讀取 CSV 檔案內容
                StreamReader inputFile;
                // 以逗號作為欄位分隔符
                char[] delim = { ',' };

                // 注意：中文檔案常見編碼為 UTF-8（有或無 BOM）或 Big5（Code Page 950）。
                // 若直接以預設方式（如 File.OpenText）讀取會因編碼不符而導致中文亂碼。
                // 此處改為以 Big5 (code page 950) 讀取，若您的 CSV 為 UTF-8（含 BOM）請改用 Encoding.UTF8。
                Encoding fileEncoding = Encoding.GetEncoding(950); // Big5 繁體中文常用編碼

                // 在讀取前清空先前的資料集合與顯示結果
                gradeBook.Clear();
                averagesListBox.Items.Clear();

                // 使用 using 敘述確保檔案在使用完畢後正確關閉與釋放資源
                using (inputFile = new StreamReader("Grades.csv", fileEncoding))
                {
                    string line; // 儲存目前讀取到的一整行字串
                    while (!inputFile.EndOfStream)
                    {
                        // 逐行讀取 CSV
                        line = inputFile.ReadLine();
                        // 以逗號分割每一列的欄位，並去除各欄位前後空白
                        string[] fields = line.Split(delim).Select(s => s.Trim()).ToArray();
                        // 新的檔案格式：班級,學號,姓名,score1,score2,score3,score4,score5
                        // 因此預期欄位數為 8
                        if (fields.Length == 8)
                        {
                            string className = fields[0]; // 班級
                            string studentId = fields[1]; // 學號
                            string studentName = fields[2]; // 姓名

                            // 建立 Student 物件並填入資料
                            Student st = new Student();
                            st.ClassName = className;
                            st.Id = studentId;
                            st.Name = studentName;
                            st.Scores = new int[5];

                            bool validScores = true; // 標示分數格式是否都為整數

                            // 解析第 3~7 個欄位為 5 個分數（index 3..7）
                            for (int i = 3; i <= 7; i++)
                            {
                                int score;
                                if (int.TryParse(fields[i], out score))
                                {
                                    st.Scores[i - 3] = score; // 將分數放入 Student.Scores 陣列
                                }
                                else
                                {
                                    // 若任一分數無法解析為整數，標示為無效並跳出
                                    validScores = false;
                                    break;
                                }
                            }

                            if (!validScores)
                            {
                                // 分數格式錯誤，顯示錯誤訊息並跳過該行
                                MessageBox.Show("分數格式錯誤: " + line);
                                continue;
                            }

                            // 將解析成功的學生加入 gradeBook
                            gradeBook.Add(st);
                        }
                        else
                        {
                            // 若欄位數目不正確，顯示錯誤訊息並包含原始那一行內容
                            MessageBox.Show("資料格式錯誤: " + line);
                        }
                    }
                }

                // 讀取完成後，依據 gradeBook 產生顯示內容（班級 學號 姓名 平均成績）
                foreach (var s in gradeBook)
                {
                    // 使用 LINQ Average 計算平均（回傳 double）
                    double avg = s.Scores.Average();
                    averagesListBox.Items.Add(string.Format("{0} {1} {2} {3:F2}", s.ClassName, s.Id, s.Name, avg));
                }
            }
            catch (Exception ex)
            {
                // 捕捉所有例外並以訊息方塊提示使用者發生的錯誤內容
                MessageBox.Show("讀取檔案時發生錯誤: " + ex.Message);
            }
        }

        // 按鈕事件：當使用者按下「離開」按鈕時關閉視窗
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}

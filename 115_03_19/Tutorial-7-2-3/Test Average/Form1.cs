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
            int total = 0;
            for (int i = 0; i < sArray.Length; i++)
            {
                total += sArray[i];
            }
            return (double)total / sArray.Length;

        }

        // Highest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最大值。
        private int Highest(int[] sArray )
        {
            int[] scoreCopy = new int[sArray.Length];
            for(int i = 0;i < sArray.Length;i++)
            {
                scoreCopy[i] = sArray[i];
            }
            Array.Sort(scoreCopy);
            return sArray[sArray.Length-1];

        }

        // Lowest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最小值。
        private int Lowest(int[] sArray )
        {
            int[] scoreCopy = new int[sArray.Length];
            for (int i = 0; i < sArray.Length; i++)
            {
                scoreCopy[i] = sArray[i];
            }
            Array.Sort(scoreCopy);
            return sArray[0];
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
            //int size = getFileScoreCount();
            int[] scores = new int[getFileScoreCount()];
            StreamReader inputFile;
            int index = 0;

            try
            {
                inputFile = File.OpenText("TestScores.txt");

                while (!inputFile.EndOfStream && index < scores.Length)
                {

                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;

                }
                inputFile.Close();

                testScoresListBox.Items.Add(" 學生人數 : " +   scores.Length + "人");
                foreach (int val in scores)
                {
                    testScoresListBox.Items.Add(val);
                }   
            }
            catch (Exception ex)
            { 
                 MessageBox.Show(ex.Message);
            }

            //double averageScore = Average(scores);
            averageScoreLabel.Text = Average(scores).ToString("n1");
            highScoreLabel.Text = Highest(scores).ToString();
            lowScoreLabel.Text = Lowest(scores).ToString();


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

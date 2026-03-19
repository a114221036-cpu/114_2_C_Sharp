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

        private double Average(int[] sArray, int count)
        {
            int total = 0;
            for (int i = 0; i < sArray.Length; i++)
            {
                total += sArray[i];
            }
            return (double)total / count;

        }

        // Highest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最大值。
        private int Highest(int[] sArray, int count )
        {
            int highScore = sArray[0];
            for (int i = 1; i < sArray.Length; i++)
            {
                if (sArray[i] > highScore)
                {
                    highScore = sArray[i];
                }
            }
            return highScore;

        }

        // Lowest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最小值。
        private int Lowest(int[] sArray, int count )
        {
            int lowScore = sArray[0];
            for (int i = 1; i < sArray.Length; i++)
            {
                if (sArray[i] < lowScore)
                {
                    lowScore = sArray[i];
                }
            }
            return lowScore;
        }


        private void getScoresButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 60;
            int[] scores = new int[SIZE];
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
            averageScoreLabel.Text = Average(scores, index).ToString("n1");
            highScoreLabel.Text = Highest(scores, index).ToString();
            lowScoreLabel.Text = Lowest(scores, index).ToString();


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

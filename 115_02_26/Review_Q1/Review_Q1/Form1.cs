using System;
using System.Windows.Forms;

namespace Review_Q1
{
    public partial class Form1 : Form
    {
        // 遊戲狀態欄位
        private readonly Random rnd = new();
        private string compChoice = string.Empty;
        private string playerChoice = string.Empty;
        private int playerWins = 0;
        private int compWins = 0;
        private int ties = 0;

        public Form1()
        {
            InitializeComponent();

            // 若設計器未綁定事件，於此綁定以確保功能可用
            stoneButton.Click += stoneButton_Click;
            paperButton.Click += paperButton_Click;
            scissorButton.Click += scissorButton_Click;
            exitButton.Click += exitButton_Click;
            Load += Form1_Load;
        }

        // 產生電腦的隨機選擇（石頭/布/剪刀），並儲存到 compChoice
        private void getCompChoice()
        {
            int r = rnd.Next(3); // 0,1,2
            compChoice = r switch
            {
                0 => "石頭",
                1 => "布",
                _ => "剪刀",
            };
        }

        // 根據電腦的選擇，在對應的 PictureBox 中顯示正確的圖片
        private void showComputerImage()
        {
            if (string.IsNullOrEmpty(compChoice))
            {
                computerPictureBox.Image = null;
                computerPictureBox.Visible = false;
                return;
            }

            computerPictureBox.Visible = true;
            switch (compChoice)
            {
                case "石頭":
                    computerPictureBox.Image = Properties.Resources.stone_computer;
                    break;
                case "布":
                    computerPictureBox.Image = Properties.Resources.paper_computer;
                    break;
                case "剪刀":
                    computerPictureBox.Image = Properties.Resources.scissor_computer;
                    break;
                default:
                    computerPictureBox.Image = null;
                    computerPictureBox.Visible = false;
                    break;
            }
        }

        // 根據玩家的選擇，在對應的 PictureBox 中顯示正確的圖片
        private void showPlayerImage()
        {
            if (string.IsNullOrEmpty(playerChoice))
            {
                playerPictureBox.Image = null;
                playerPictureBox.Visible = false;
                return;
            }

            playerPictureBox.Visible = true;
            switch (playerChoice)
            {
                case "石頭":
                    playerPictureBox.Image = Properties.Resources.stone_player;
                    break;
                case "布":
                    playerPictureBox.Image = Properties.Resources.paper_player;
                    break;
                case "剪刀":
                    playerPictureBox.Image = Properties.Resources.scissor_player;
                    break;
                default:
                    playerPictureBox.Image = null;
                    playerPictureBox.Visible = false;
                    break;
            }
        }

        // 比較玩家和電腦的選擇，判斷輸贏，更新勝場計數，並顯示結果
        private void showWinner()
        {
            if (string.IsNullOrEmpty(playerChoice) || string.IsNullOrEmpty(compChoice))
            {
                resultLabel.Text = string.Empty;
                return;
            }

            if (playerChoice == compChoice)
            {
                ties++;
                resultLabel.Text = "平手";
                return;
            }

            bool playerWinsRound = (playerChoice == "石頭" && compChoice == "剪刀")
                                   || (playerChoice == "布" && compChoice == "石頭")
                                   || (playerChoice == "剪刀" && compChoice == "布");

            if (playerWinsRound)
            {
                playerWins++;
                resultLabel.Text = "玩家贏";
            }
            else
            {
                compWins++;
                resultLabel.Text = "電腦贏";
            }
        }

        // 事件處理方法 - 玩家選擇石頭
        private void stoneButton_Click(object? sender, EventArgs e)
        {
            playerChoice = "石頭";
            showPlayerImage();
            getCompChoice();
            showComputerImage();
            showWinner();
        }

        // 事件處理方法 - 玩家選擇布
        private void paperButton_Click(object? sender, EventArgs e)
        {
            playerChoice = "布";
            showPlayerImage();
            getCompChoice();
            showComputerImage();
            showWinner();
        }

        // 事件處理方法 - 玩家選擇剪刀
        private void scissorButton_Click(object? sender, EventArgs e)
        {
            playerChoice = "剪刀";
            showPlayerImage();
            getCompChoice();
            showComputerImage();
            showWinner();
        }

        // 事件處理方法 - 結束遊戲並顯示統計
        private void exitButton_Click(object? sender, EventArgs e)
        {
            string stats = $"遊戲統計：\n玩家勝場：{playerWins}\n電腦勝場：{compWins}\n平手：{ties}";
            MessageBox.Show(stats, "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        // 表單載入初始化：清空圖片與結果顯示
        private void Form1_Load(object? sender, EventArgs e)
        {
            computerPictureBox.Image = null;
            computerPictureBox.Visible = false;
            playerPictureBox.Image = null;
            playerPictureBox.Visible = false;
            resultLabel.Text = string.Empty;

            playerChoice = string.Empty;
            compChoice = string.Empty;
            playerWins = 0;
            compWins = 0;
            ties = 0;
        }

        private void computerPictureBox_Click(object sender, EventArgs e)
        {
            // 保留設計器自動產生的空處理器（若不需可移除）
        }

        private void playerPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void stoneButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}

namespace Review_Q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button exitButton;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            computerPictureBox = new PictureBox();
            playerPictureBox = new PictureBox();
            computerLabel = new Label();
            playerLabel = new Label();
            resultLabel = new Label();
            stoneButton = new Button();
            paperButton = new Button();
            scissorButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // computerPictureBox
            // 
            computerPictureBox.BackColor = Color.FromArgb(240, 236, 230);
            computerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            computerPictureBox.Image = Properties.Resources.paper_computer;
            computerPictureBox.Location = new Point(40, 50);
            computerPictureBox.Name = "computerPictureBox";
            computerPictureBox.Size = new Size(220, 100);
            computerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            computerPictureBox.TabIndex = 2;
            computerPictureBox.TabStop = false;
            computerPictureBox.Visible = false;
            computerPictureBox.Click += computerPictureBox_Click;
            // 
            // playerPictureBox
            // 
            playerPictureBox.BackColor = Color.FromArgb(240, 236, 230);
            playerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            playerPictureBox.Image = Properties.Resources.stone_player;
            playerPictureBox.Location = new Point(360, 50);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(220, 100);
            playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerPictureBox.TabIndex = 3;
            playerPictureBox.TabStop = false;
            playerPictureBox.Visible = false;
            playerPictureBox.Click += playerPictureBox_Click;
            // 
            // computerLabel
            // 
            computerLabel.AutoSize = true;
            computerLabel.Font = new Font("微軟正黑體", 12F);
            computerLabel.Location = new Point(110, 18);
            computerLabel.Name = "computerLabel";
            computerLabel.Size = new Size(85, 30);
            computerLabel.TabIndex = 0;
            computerLabel.Text = "電腦出";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("微軟正黑體", 12F);
            playerLabel.Location = new Point(420, 18);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(85, 30);
            playerLabel.TabIndex = 1;
            playerLabel.Text = "玩家出";
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Font = new Font("微軟正黑體", 20F);
            resultLabel.Location = new Point(120, 170);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(380, 48);
            resultLabel.TabIndex = 4;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stoneButton
            // 
            stoneButton.Font = new Font("微軟正黑體", 18F);
            stoneButton.Location = new Point(60, 230);
            stoneButton.Name = "stoneButton";
            stoneButton.Size = new Size(140, 60);
            stoneButton.TabIndex = 5;
            stoneButton.Text = "石頭";
            stoneButton.UseVisualStyleBackColor = true;
            stoneButton.Click += stoneButton_Click_1;
            // 
            // paperButton
            // 
            paperButton.Font = new Font("微軟正黑體", 18F);
            paperButton.Location = new Point(240, 230);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(140, 60);
            paperButton.TabIndex = 6;
            paperButton.Text = "布";
            paperButton.UseVisualStyleBackColor = true;
            // 
            // scissorButton
            // 
            scissorButton.Font = new Font("微軟正黑體", 18F);
            scissorButton.Location = new Point(420, 230);
            scissorButton.Name = "scissorButton";
            scissorButton.Size = new Size(140, 60);
            scissorButton.TabIndex = 7;
            scissorButton.Text = "剪刀";
            scissorButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("微軟正黑體", 18F);
            exitButton.Location = new Point(220, 310);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(180, 60);
            exitButton.TabIndex = 8;
            exitButton.Text = "結束遊戲";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 420);
            Controls.Add(computerLabel);
            Controls.Add(playerLabel);
            Controls.Add(computerPictureBox);
            Controls.Add(playerPictureBox);
            Controls.Add(resultLabel);
            Controls.Add(stoneButton);
            Controls.Add(paperButton);
            Controls.Add(scissorButton);
            Controls.Add(exitButton);
            Name = "Form1";
            Text = "猜拳遊戲";
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

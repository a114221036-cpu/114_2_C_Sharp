namespace Coin_Toss
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            // 註解：輸出用的 ListBox。將字型大小設為 18，以利繁體中文顯示與可讀性。
            // 並放大 ListBox 以容納較大的字型與多行顯示結果，位置靠上方並保留邊界。
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListBox.Location = new System.Drawing.Point(16, 16);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(328, 160);
            this.outputListBox.TabIndex = 0;
            // 
            // tossButton
            // 
            // 註解：擲硬幣按鈕。文字改為繁體中文「擲五次硬幣」，並使用 18pt 字型以保持一致性。
            // 調整按鈕大小與位置至 ListBox 下方偏左，方便操作與布局平衡。
            this.tossButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tossButton.Location = new System.Drawing.Point(24, 192);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(160, 48);
            this.tossButton.TabIndex = 1;
            this.tossButton.Text = "擲五次硬幣";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            // 註解：離開按鈕。文字改為繁體中文「離開」，字型也設為 18pt，並放置於右側與擲按鈕對齊。
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(200, 192);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 48);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 註解：視窗標題改為繁體中文「擲硬幣模擬器」，並擴大表單以容納放大的字型與元件。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 260);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "擲硬幣模擬器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
    }
}


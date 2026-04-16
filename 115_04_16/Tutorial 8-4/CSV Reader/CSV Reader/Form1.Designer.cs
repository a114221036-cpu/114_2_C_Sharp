namespace CSV_Reader
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源，則為 true；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 表單設計工具產生的程式碼

        /// <summary>
        /// 設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.averagesListBox = new System.Windows.Forms.ListBox();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averagesListBox
            // 
            this.averagesListBox.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.averagesListBox.FormattingEnabled = true;
            this.averagesListBox.ItemHeight = 45;
            this.averagesListBox.Location = new System.Drawing.Point(37, 56);
            this.averagesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.averagesListBox.Name = "averagesListBox";
            this.averagesListBox.Size = new System.Drawing.Size(538, 229);
            this.averagesListBox.TabIndex = 0;
            // 
            // getScoresButton
            // 
            this.getScoresButton.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.getScoresButton.Location = new System.Drawing.Point(105, 323);
            this.getScoresButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(180, 69);
            this.getScoresButton.TabIndex = 1;
            this.getScoresButton.Text = "取得成績";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.exitButton.Location = new System.Drawing.Point(345, 323);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 69);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 536);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averagesListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "CSV 讀取器";
            this.ResumeLayout(false);

        }

        #endregion

        // 用於顯示計算出的平均成績
        private System.Windows.Forms.ListBox averagesListBox;
        // 用於觸發讀取 CSV 檔案的按鈕
        private System.Windows.Forms.Button getScoresButton;
        // 用於關閉應用程式的按鈕
        private System.Windows.Forms.Button exitButton;
    }
}


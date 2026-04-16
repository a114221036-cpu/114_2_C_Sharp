namespace Telephone_Unformat
{
    // 電話號碼格式轉換表單 - 使用者介面設計類
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具容器變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有使用中的資源。
        /// </summary>
        /// <param name="disposing">若要釋放 Managed 資源，則為 true；否則為 false。</param>
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
        /// 設計工具支援所需的方法 - 請勿使用程式碼編輯器修改此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.unformatButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 18F);
            this.exitButton.Location = new System.Drawing.Point(363, 251);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 55);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // unformatButton
            // 
            this.unformatButton.Font = new System.Drawing.Font("新細明體", 18F);
            this.unformatButton.Location = new System.Drawing.Point(134, 251);
            this.unformatButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unformatButton.Name = "unformatButton";
            this.unformatButton.Size = new System.Drawing.Size(150, 55);
            this.unformatButton.TabIndex = 6;
            this.unformatButton.Text = "移除格式";
            this.unformatButton.UseVisualStyleBackColor = true;
            this.unformatButton.Click += new System.EventHandler(this.unformatButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("新細明體", 18F);
            this.instructionLabel.Location = new System.Drawing.Point(79, 44);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(495, 97);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.Text = "請輸入電話號碼，格式為 (XXX)XXX-XXXX，\r\n我將為您移除格式符號。";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("新細明體", 18F);
            this.numberTextBox.Location = new System.Drawing.Point(145, 159);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(343, 51);
            this.numberTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 484);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.unformatButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.numberTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "電話號碼格式轉換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 結束按鈕 - 用於關閉應用程式
        private System.Windows.Forms.Button exitButton;
        
        // 移除格式按鈕 - 用於執行電話號碼去格式化操作
        private System.Windows.Forms.Button unformatButton;
        
        // 說明標籤 - 顯示使用者操作提示訊息
        private System.Windows.Forms.Label instructionLabel;
        
        // 輸入文字框 - 供使用者輸入電話號碼
        private System.Windows.Forms.TextBox numberTextBox;
    }
}


namespace Multiform_Practice
{
    partial class MainForm
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
            this.displayFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayFormButton
            // 
            // 設定 "顯示表單" 按鈕的位置、大小與字型，字型大小改為 18，避免與其他元件重疊
            this.displayFormButton.Location = new System.Drawing.Point(30, 25);
            this.displayFormButton.Name = "displayFormButton";
            this.displayFormButton.Size = new System.Drawing.Size(180, 60);
            this.displayFormButton.TabIndex = 0;
            // 將按鈕文字改為繁體中文
            this.displayFormButton.Text = "顯示表單";
            // 設定按鈕字型為適合繁體中文顯示的字型，字型大小為 18
            this.displayFormButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.displayFormButton.UseVisualStyleBackColor = true;
            this.displayFormButton.Click += new System.EventHandler(this.displayFormButton_Click);
            // 
            // exitButton
            // 
            // 設定 "離開" 按鈕的位置、大小與字型，避免與顯示表單按鈕重疊
            this.exitButton.Location = new System.Drawing.Point(230, 25);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 60);
            this.exitButton.TabIndex = 1;
            // 將按鈕文字改為繁體中文
            this.exitButton.Text = "離開";
            // 設定按鈕字型為適合繁體中文顯示的字型，字型大小為 18
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            // 調整表單整體字型與大小，並設定為繁體中文標題
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 將表單大小放大以容納較大的按鈕與字型，避免元件遮蔽
            this.ClientSize = new System.Drawing.Size(380, 110);
            // 將按鈕加入表單控制項，維持原有加入順序
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayFormButton);
            this.Name = "MainForm";
            // 將表單標題改為繁體中文
            this.Text = "多表單練習";
            // 設定表單預設字型為繁體中文字型，字型大小為 18，讓表單上其他元件也能一致顯示
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayFormButton;
        private System.Windows.Forms.Button exitButton;
    }
}


                                                                                                namespace Cell_Phone_Test
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
        /// 
        /// 下列程式碼已修改：
        /// - 將所有元件的 Text 屬性改為繁體中文
        /// - 將所有顯示文字的字型大小改為 18
        /// - 適度調整每個元件的 Size 與 Location 以配合較大的字型
        /// - 在 InitializeComponent 中以繁體中文加入詳細註解（說明調整原因與目的）
        /// 
        /// 注意：未更動元件名稱、事件綁定或其他邏輯，只調整顯示文字、字型與版面配置。
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.objectPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.outputPriceLabel = new System.Windows.Forms.Label();
            this.outputModelLabel = new System.Windows.Forms.Label();
            this.outputBrandLabel = new System.Windows.Forms.Label();
            this.enterDataGroupBox = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.promptPriceLabel = new System.Windows.Forms.Label();
            this.promptModelLabel = new System.Windows.Forms.Label();
            this.promptBrandLabel = new System.Windows.Forms.Label();
            this.objectPropertiesGroupBox.SuspendLayout();
            this.enterDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            // 說明：離開按鈕，文字改為繁體中文「離開」，字型改為 18，尺寸與位置調整以配合整體佈局。
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(210, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createObjectButton
            // 
            // 說明：建立物件按鈕，文字改為繁體中文「建立物件」，字型 18，尺寸與位置調整。
            this.createObjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createObjectButton.Location = new System.Drawing.Point(28, 360);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(160, 50);
            this.createObjectButton.TabIndex = 6;
            this.createObjectButton.Text = "建立物件";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // objectPropertiesGroupBox
            // 
            // 說明：物件屬性群組，標題改為繁體中文「物件屬性」，內部三個屬性顯示區域字型皆改為 18，並放大以利閱讀。
            this.objectPropertiesGroupBox.Controls.Add(this.priceLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.modelLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.brandLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputPriceLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputModelLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputBrandLabel);
            this.objectPropertiesGroupBox.Location = new System.Drawing.Point(18, 160);
            this.objectPropertiesGroupBox.Name = "objectPropertiesGroupBox";
            this.objectPropertiesGroupBox.Size = new System.Drawing.Size(332, 180);
            this.objectPropertiesGroupBox.TabIndex = 5;
            this.objectPropertiesGroupBox.TabStop = false;
            this.objectPropertiesGroupBox.Text = "物件屬性";
            // 
            // priceLabel
            // 
            // 說明：顯示價格的值欄位，保留原有 BorderStyle 並置中對齊，字型放大為 18，尺寸加高以容納大字。
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(120, 118);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(190, 40);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelLabel
            // 
            // 說明：顯示型號的值欄位，字型 18，尺寸與價格欄一致以保持 UI 一致性。
            this.modelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(120, 72);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(190, 40);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandLabel
            // 
            // 說明：顯示品牌的值欄位，字型 18，尺寸與其他值欄一致。
            this.brandLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(120, 26);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(190, 40);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputPriceLabel
            // 
            // 說明：輸出區的提示文字（價格），改為繁體中文「價格：」，字型 18，AutoSize 保留讓標籤依字型大小調整寬度。
            this.outputPriceLabel.AutoSize = true;
            this.outputPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPriceLabel.Location = new System.Drawing.Point(22, 126);
            this.outputPriceLabel.Name = "outputPriceLabel";
            this.outputPriceLabel.Size = new System.Drawing.Size(74, 29);
            this.outputPriceLabel.TabIndex = 5;
            this.outputPriceLabel.Text = "價格：";
            // 
            // outputModelLabel
            // 
            // 說明：輸出區的提示文字（型號），改為繁體中文「型號：」，字型 18。
            this.outputModelLabel.AutoSize = true;
            this.outputModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputModelLabel.Location = new System.Drawing.Point(22, 80);
            this.outputModelLabel.Name = "outputModelLabel";
            this.outputModelLabel.Size = new System.Drawing.Size(74, 29);
            this.outputModelLabel.TabIndex = 4;
            this.outputModelLabel.Text = "型號：";
            // 
            // outputBrandLabel
            // 
            // 說明：輸出區的提示文字（品牌），改為繁體中文「品牌：」，字型 18。
            this.outputBrandLabel.AutoSize = true;
            this.outputBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBrandLabel.Location = new System.Drawing.Point(22, 34);
            this.outputBrandLabel.Name = "outputBrandLabel";
            this.outputBrandLabel.Size = new System.Drawing.Size(74, 29);
            this.outputBrandLabel.TabIndex = 3;
            this.outputBrandLabel.Text = "品牌：";
            // 
            // enterDataGroupBox
            // 
            // 說明：輸入資料群組，標題改為繁體中文「輸入手機資料」，內部提示與輸入欄位字型皆改為 18，並放大欄位高度。
            this.enterDataGroupBox.Controls.Add(this.priceTextBox);
            this.enterDataGroupBox.Controls.Add(this.modelTextBox);
            this.enterDataGroupBox.Controls.Add(this.brandTextBox);
            this.enterDataGroupBox.Controls.Add(this.promptPriceLabel);
            this.enterDataGroupBox.Controls.Add(this.promptModelLabel);
            this.enterDataGroupBox.Controls.Add(this.promptBrandLabel);
            this.enterDataGroupBox.Location = new System.Drawing.Point(18, 12);
            this.enterDataGroupBox.Name = "enterDataGroupBox";
            this.enterDataGroupBox.Size = new System.Drawing.Size(332, 140);
            this.enterDataGroupBox.TabIndex = 4;
            this.enterDataGroupBox.TabStop = false;
            this.enterDataGroupBox.Text = "輸入手機資料";
            // 
            // priceTextBox
            // 
            // 說明：價格輸入框，字型 18，增加高度以便顯示較大字體。
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(120, 92);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(190, 35);
            this.priceTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            // 說明：型號輸入框，字型 18，增加高度與寬度。
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(120, 54);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(190, 35);
            this.modelTextBox.TabIndex = 4;
            // 
            // brandTextBox
            // 
            // 說明：品牌輸入框，字型 18，增加高度與寬度。
            this.brandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTextBox.Location = new System.Drawing.Point(120, 16);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(190, 35);
            this.brandTextBox.TabIndex = 3;
            // 
            // promptPriceLabel
            // 
            // 說明：輸入區提示（價格），改為繁體中文「價格：」，字型 18。
            this.promptPriceLabel.AutoSize = true;
            this.promptPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptPriceLabel.Location = new System.Drawing.Point(22, 96);
            this.promptPriceLabel.Name = "promptPriceLabel";
            this.promptPriceLabel.Size = new System.Drawing.Size(74, 29);
            this.promptPriceLabel.TabIndex = 2;
            this.promptPriceLabel.Text = "價格：";
            // 
            // promptModelLabel
            // 
            // 說明：輸入區提示（型號），改為繁體中文「型號：」，字型 18。
            this.promptModelLabel.AutoSize = true;
            this.promptModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptModelLabel.Location = new System.Drawing.Point(22, 58);
            this.promptModelLabel.Name = "promptModelLabel";
            this.promptModelLabel.Size = new System.Drawing.Size(74, 29);
            this.promptModelLabel.TabIndex = 1;
            this.promptModelLabel.Text = "型號：";
            // 
            // promptBrandLabel
            // 
            // 說明：輸入區提示（品牌），改為繁體中文「品牌：」，字型 18。
            this.promptBrandLabel.AutoSize = true;
            this.promptBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptBrandLabel.Location = new System.Drawing.Point(22, 20);
            this.promptBrandLabel.Name = "promptBrandLabel";
            this.promptBrandLabel.Size = new System.Drawing.Size(74, 29);
            this.promptBrandLabel.TabIndex = 0;
            this.promptBrandLabel.Text = "品牌：";
            // 
            // Form1
            // 
            // 說明：表單大小依照字型調整為較大的 ClientSize，以容納放大的字型與元件。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 430);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.objectPropertiesGroupBox);
            this.Controls.Add(this.enterDataGroupBox);
            this.Name = "Form1";
            this.Text = "手機測試";
            this.objectPropertiesGroupBox.ResumeLayout(false);
            this.objectPropertiesGroupBox.PerformLayout();
            this.enterDataGroupBox.ResumeLayout(false);
            this.enterDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.GroupBox objectPropertiesGroupBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label outputPriceLabel;
        private System.Windows.Forms.Label outputModelLabel;
        private System.Windows.Forms.Label outputBrandLabel;
        private System.Windows.Forms.GroupBox enterDataGroupBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label promptPriceLabel;
        private System.Windows.Forms.Label promptModelLabel;
        private System.Windows.Forms.Label promptBrandLabel;
    }
}


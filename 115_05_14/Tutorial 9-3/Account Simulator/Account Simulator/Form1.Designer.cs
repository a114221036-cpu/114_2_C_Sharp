namespace Account_Simulator
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
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.depositGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositGroupBox
            // 
            this.depositGroupBox.Controls.Add(this.depositButton);
            this.depositGroupBox.Controls.Add(this.depositTextBox);
            this.depositGroupBox.Controls.Add(this.depositAmountDescriptionLabel);
            this.depositGroupBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.depositGroupBox.Location = new System.Drawing.Point(47, 225);
            this.depositGroupBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.depositGroupBox.Size = new System.Drawing.Size(496, 272);
            this.depositGroupBox.TabIndex = 0;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "存款";
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.depositButton.Location = new System.Drawing.Point(151, 153);
            this.depositButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(233, 100);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "存款";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositTextBox
            // 
            this.depositTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.depositTextBox.Location = new System.Drawing.Point(167, 75);
            this.depositTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(251, 55);
            this.depositTextBox.TabIndex = 1;
            // 
            // depositAmountDescriptionLabel
            // 
            this.depositAmountDescriptionLabel.AutoSize = true;
            this.depositAmountDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.depositAmountDescriptionLabel.Location = new System.Drawing.Point(48, 82);
            this.depositAmountDescriptionLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.depositAmountDescriptionLabel.Name = "depositAmountDescriptionLabel";
            this.depositAmountDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.depositAmountDescriptionLabel.TabIndex = 0;
            this.depositAmountDescriptionLabel.Text = "金額：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withdrawButton);
            this.groupBox1.Controls.Add(this.withdrawTextBox);
            this.groupBox1.Controls.Add(this.withdrawAmountDescriptionLabel);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(619, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Size = new System.Drawing.Size(496, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提款";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.withdrawButton.Location = new System.Drawing.Point(136, 153);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(233, 100);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "提款";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.withdrawTextBox.Location = new System.Drawing.Point(181, 79);
            this.withdrawTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(251, 55);
            this.withdrawTextBox.TabIndex = 1;
            // 
            // withdrawAmountDescriptionLabel
            // 
            this.withdrawAmountDescriptionLabel.AutoSize = true;
            this.withdrawAmountDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.withdrawAmountDescriptionLabel.Location = new System.Drawing.Point(39, 85);
            this.withdrawAmountDescriptionLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.withdrawAmountDescriptionLabel.Name = "withdrawAmountDescriptionLabel";
            this.withdrawAmountDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.withdrawAmountDescriptionLabel.TabIndex = 0;
            this.withdrawAmountDescriptionLabel.Text = "金額：";
            // 
            // balanceDescriptionLabel
            // 
            this.balanceDescriptionLabel.AutoSize = true;
            this.balanceDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.balanceDescriptionLabel.Location = new System.Drawing.Point(242, 134);
            this.balanceDescriptionLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.balanceDescriptionLabel.Name = "balanceDescriptionLabel";
            this.balanceDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.balanceDescriptionLabel.TabIndex = 2;
            this.balanceDescriptionLabel.Text = "餘額：";
            // 
            // balanceLabel
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.balanceLabel.Location = new System.Drawing.Point(406, 121);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(364, 71);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(475, 524);
            this.exitButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(219, 79);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 800);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceDescriptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.depositGroupBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form1";
            this.Text = "帳戶模擬器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox depositGroupBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label depositAmountDescriptionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Label withdrawAmountDescriptionLabel;
        private System.Windows.Forms.Label balanceDescriptionLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button exitButton;
    }
}


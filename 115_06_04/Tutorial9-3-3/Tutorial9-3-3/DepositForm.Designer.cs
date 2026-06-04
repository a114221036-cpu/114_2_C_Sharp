namespace Tutorial9_3_3
{
    partial class DepositForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // 表單介面元件（僅介面，不包含程式邏輯）
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnExit;
        // 顯示結果用的標籤（僅介面，執行時可由程式更新文字）
        private System.Windows.Forms.Label lblResult;

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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.lblAccount);
            this.pnlContainer.Controls.Add(this.txtAccount);
            this.pnlContainer.Controls.Add(this.lblAmount);
            this.pnlContainer.Controls.Add(this.txtAmount);
            this.pnlContainer.Controls.Add(this.btnDeposit);
            this.pnlContainer.Controls.Add(this.btnExit);
            this.pnlContainer.Location = new System.Drawing.Point(10, 10);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(420, 260);
            this.pnlContainer.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 66);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "存款";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.lblAccount.Location = new System.Drawing.Point(20, 70);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(128, 45);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "帳號：";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.txtAccount.Location = new System.Drawing.Point(130, 66);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(240, 50);
            this.txtAccount.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.lblAmount.Location = new System.Drawing.Point(20, 120);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(128, 45);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "金額：";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.txtAmount.Location = new System.Drawing.Point(130, 116);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(240, 50);
            this.txtAmount.TabIndex = 5;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.btnDeposit.Location = new System.Drawing.Point(150, 170);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(120, 50);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "存入";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btnExit.Location = new System.Drawing.Point(276, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblResult.Location = new System.Drawing.Point(10, 280);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(420, 40);
            this.lblResult.TabIndex = 8;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 608);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblResult);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Name = "DepositForm";
            this.Text = "存款";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
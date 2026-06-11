namespace 員工資料管理系統
{
    partial class 查詢員工
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtOutputArea;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtOutputArea = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // 
            // 查詢員工 (Form)
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 420);
            this.Text = "查詢員工";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "查詢員工";

            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblEmployeeId.Location = new System.Drawing.Point(30, 86);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(120, 24);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "員工編號：";

            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtEmployeeId.Location = new System.Drawing.Point(200, 84);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(400, 27);
            this.txtEmployeeId.TabIndex = 2;

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(220, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;

            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(360, 130);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "離開";
            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // txtOutputArea
            // 
            this.txtOutputArea.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtOutputArea.Location = new System.Drawing.Point(24, 190);
            this.txtOutputArea.Multiline = true;
            this.txtOutputArea.Name = "txtOutputArea";
            this.txtOutputArea.ReadOnly = true;
            this.txtOutputArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputArea.Size = new System.Drawing.Size(672, 200);
            this.txtOutputArea.TabIndex = 5;
            this.txtOutputArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // 查詢員工 - Add controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtOutputArea);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
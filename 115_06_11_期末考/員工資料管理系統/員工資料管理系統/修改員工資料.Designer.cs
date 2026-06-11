namespace 員工資料管理系統
{
    partial class 修改員工資料
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnSave;
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtOutputArea = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // 
            // 修改員工資料 (Form)
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 560);
            this.Text = "修改員工資料";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(22, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "修改員工資料";

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
            this.txtEmployeeId.Size = new System.Drawing.Size(360, 27);
            this.txtEmployeeId.TabIndex = 2;

            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(200, 124);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 36);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblName.Location = new System.Drawing.Point(30, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "姓名：";

            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtName.Location = new System.Drawing.Point(200, 178);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(460, 27);
            this.txtName.TabIndex = 5;

            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblDepartment.Location = new System.Drawing.Point(30, 230);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(72, 24);
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "部門：";

            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtDepartment.Location = new System.Drawing.Point(200, 228);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(460, 27);
            this.txtDepartment.TabIndex = 7;

            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblPosition.Location = new System.Drawing.Point(30, 280);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(72, 24);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "職稱：";

            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtPosition.Location = new System.Drawing.Point(200, 278);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(460, 27);
            this.txtPosition.TabIndex = 9;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(240, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;

            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(380, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 40);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "離開";
            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // txtOutputArea
            // 
            this.txtOutputArea.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtOutputArea.Location = new System.Drawing.Point(24, 390);
            this.txtOutputArea.Multiline = true;
            this.txtOutputArea.Name = "txtOutputArea";
            this.txtOutputArea.ReadOnly = true;
            this.txtOutputArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputArea.Size = new System.Drawing.Size(672, 120);
            this.txtOutputArea.TabIndex = 12;
            this.txtOutputArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // 修改員工資料 - Add controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtOutputArea);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
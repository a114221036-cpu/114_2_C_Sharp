namespace 員工資料管理系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Label lblListHeader;
        private System.Windows.Forms.Panel leftButtonPanel;

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
            this.leftButtonPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblListHeader = new System.Windows.Forms.Label();
            this.employeeListBox = new System.Windows.Forms.ListBox();

            // 
            // Form1
            // 
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Text = "員工資料管理";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "員工資料管理";

            // 
            // leftButtonPanel
            // 
            this.leftButtonPanel.Location = new System.Drawing.Point(18, 70);
            this.leftButtonPanel.Name = "leftButtonPanel";
            this.leftButtonPanel.Size = new System.Drawing.Size(120, 260);
            this.leftButtonPanel.TabIndex = 1;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增員工";
            this.btnAdd.UseVisualStyleBackColor = true;

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "刪除員工";
            this.btnDelete.UseVisualStyleBackColor = true;

            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 102);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "修改員工";
            this.btnEdit.UseVisualStyleBackColor = true;

            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(6, 150);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(108, 36);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查詢員工";
            this.btnQuery.UseVisualStyleBackColor = true;

            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 198);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "離開";
            this.btnClose.UseVisualStyleBackColor = true;

            // add buttons to panel
            this.leftButtonPanel.Controls.Add(this.btnAdd);
            this.leftButtonPanel.Controls.Add(this.btnDelete);
            this.leftButtonPanel.Controls.Add(this.btnEdit);
            this.leftButtonPanel.Controls.Add(this.btnQuery);
            this.leftButtonPanel.Controls.Add(this.btnClose);

            // 
            // lblListHeader
            // 
            this.lblListHeader.AutoSize = true;
            this.lblListHeader.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblListHeader.Location = new System.Drawing.Point(156, 78);
            this.lblListHeader.Name = "lblListHeader";
            this.lblListHeader.Size = new System.Drawing.Size(154, 20);
            this.lblListHeader.TabIndex = 2;
            this.lblListHeader.Text = "員工編號與姓名：";

            // 
            // employeeListBox
            // 
            this.employeeListBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 16;
            this.employeeListBox.Location = new System.Drawing.Point(160, 102);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(452, 212);
            this.employeeListBox.TabIndex = 3;

            // 
            // Add controls to Form
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.leftButtonPanel);
            this.Controls.Add(this.lblListHeader);
            this.Controls.Add(this.employeeListBox);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}


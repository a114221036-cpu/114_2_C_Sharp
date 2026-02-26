namespace Review_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxOil;
        private System.Windows.Forms.CheckBox chkChangeOil;
        private System.Windows.Forms.CheckBox chkLubrication;
        private System.Windows.Forms.GroupBox groupBoxCleaning;
        private System.Windows.Forms.CheckBox chkRadiator;
        private System.Windows.Forms.CheckBox chkTransmission;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkMuffler;
        private System.Windows.Forms.CheckBox chkWheelAlign;
        private System.Windows.Forms.GroupBox groupBoxPartsLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label lblPartsSummary;
        private System.Windows.Forms.TextBox txtPartsSummary;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxOil = new GroupBox();
            chkChangeOil = new CheckBox();
            chkLubrication = new CheckBox();
            groupBoxCleaning = new GroupBox();
            chkRadiator = new CheckBox();
            chkTransmission = new CheckBox();
            groupBoxOther = new GroupBox();
            chkInspection = new CheckBox();
            chkMuffler = new CheckBox();
            chkWheelAlign = new CheckBox();
            groupBoxPartsLabor = new GroupBox();
            lblParts = new Label();
            txtParts = new TextBox();
            lblHours = new Label();
            txtHours = new TextBox();
            groupBoxSummary = new GroupBox();
            lblService = new Label();
            txtService = new TextBox();
            lblPartsSummary = new Label();
            txtPartsSummary = new TextBox();
            lblTax = new Label();
            txtTax = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBoxOil.SuspendLayout();
            groupBoxCleaning.SuspendLayout();
            groupBoxOther.SuspendLayout();
            groupBoxPartsLabor.SuspendLayout();
            groupBoxSummary.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOil
            // 
            groupBoxOil.Controls.Add(chkChangeOil);
            groupBoxOil.Controls.Add(chkLubrication);
            groupBoxOil.Location = new Point(12, 12);
            groupBoxOil.Name = "groupBoxOil";
            groupBoxOil.Size = new Size(240, 100);
            groupBoxOil.TabIndex = 0;
            groupBoxOil.TabStop = false;
            groupBoxOil.Text = "機油和潤滑";
            // 
            // chkChangeOil
            // 
            chkChangeOil.AutoSize = true;
            chkChangeOil.Location = new Point(12, 24);
            chkChangeOil.Name = "chkChangeOil";
            chkChangeOil.Size = new Size(210, 29);
            chkChangeOil.TabIndex = 0;
            chkChangeOil.Text = "更換機油 (NT$780)";
            // 
            // chkLubrication
            // 
            chkLubrication.AutoSize = true;
            chkLubrication.Location = new Point(12, 56);
            chkLubrication.Name = "chkLubrication";
            chkLubrication.Size = new Size(210, 29);
            chkLubrication.TabIndex = 1;
            chkLubrication.Text = "潤滑保養 (NT$540)";
            // 
            // groupBoxCleaning
            // 
            groupBoxCleaning.Controls.Add(chkRadiator);
            groupBoxCleaning.Controls.Add(chkTransmission);
            groupBoxCleaning.Location = new Point(268, 12);
            groupBoxCleaning.Name = "groupBoxCleaning";
            groupBoxCleaning.Size = new Size(240, 100);
            groupBoxCleaning.TabIndex = 1;
            groupBoxCleaning.TabStop = false;
            groupBoxCleaning.Text = "清洗服務";
            // 
            // chkRadiator
            // 
            chkRadiator.AutoSize = true;
            chkRadiator.Location = new Point(12, 24);
            chkRadiator.Name = "chkRadiator";
            chkRadiator.Size = new Size(210, 29);
            chkRadiator.TabIndex = 0;
            chkRadiator.Text = "水箱清洗 (NT$900)";
            // 
            // chkTransmission
            // 
            chkTransmission.AutoSize = true;
            chkTransmission.Location = new Point(12, 56);
            chkTransmission.Name = "chkTransmission";
            chkTransmission.Size = new Size(247, 29);
            chkTransmission.TabIndex = 1;
            chkTransmission.Text = "變速箱清洗 (NT$2,400)";
            // 
            // groupBoxOther
            // 
            groupBoxOther.Controls.Add(chkInspection);
            groupBoxOther.Controls.Add(chkMuffler);
            groupBoxOther.Controls.Add(chkWheelAlign);
            groupBoxOther.Location = new Point(12, 122);
            groupBoxOther.Name = "groupBoxOther";
            groupBoxOther.Size = new Size(240, 120);
            groupBoxOther.TabIndex = 2;
            groupBoxOther.TabStop = false;
            groupBoxOther.Text = "其他服務";
            // 
            // chkInspection
            // 
            chkInspection.AutoSize = true;
            chkInspection.Location = new Point(12, 24);
            chkInspection.Name = "chkInspection";
            chkInspection.Size = new Size(170, 29);
            chkInspection.TabIndex = 0;
            chkInspection.Text = "檢驗 (NT$450)";
            // 
            // chkMuffler
            // 
            chkMuffler.AutoSize = true;
            chkMuffler.Location = new Point(12, 56);
            chkMuffler.Name = "chkMuffler";
            chkMuffler.Size = new Size(247, 29);
            chkMuffler.TabIndex = 1;
            chkMuffler.Text = "更換消音器 (NT$3,000)";
            // 
            // chkWheelAlign
            // 
            chkWheelAlign.AutoSize = true;
            chkWheelAlign.Location = new Point(12, 88);
            chkWheelAlign.Name = "chkWheelAlign";
            chkWheelAlign.Size = new Size(210, 29);
            chkWheelAlign.TabIndex = 2;
            chkWheelAlign.Text = "輪胎定位 (NT$600)";
            // 
            // groupBoxPartsLabor
            // 
            groupBoxPartsLabor.Controls.Add(lblParts);
            groupBoxPartsLabor.Controls.Add(txtParts);
            groupBoxPartsLabor.Controls.Add(lblHours);
            groupBoxPartsLabor.Controls.Add(txtHours);
            groupBoxPartsLabor.Location = new Point(268, 122);
            groupBoxPartsLabor.Name = "groupBoxPartsLabor";
            groupBoxPartsLabor.Size = new Size(240, 120);
            groupBoxPartsLabor.TabIndex = 3;
            groupBoxPartsLabor.TabStop = false;
            groupBoxPartsLabor.Text = "零件和工時";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(12, 28);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(108, 25);
            lblParts.TabIndex = 0;
            lblParts.Text = "零件 (NT$)";
            // 
            // txtParts
            // 
            txtParts.Location = new Point(110, 24);
            txtParts.Name = "txtParts";
            txtParts.Size = new Size(110, 34);
            txtParts.TabIndex = 1;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(12, 68);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(129, 25);
            lblHours.TabIndex = 2;
            lblHours.Text = "工時數 (小時)";
            // 
            // txtHours
            // 
            // 已將工時輸入欄放在 lblHours 右側，方便直接輸入工時數
            txtHours.Location = new Point(151, 64);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(110, 34);
            txtHours.TabIndex = 3;
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Controls.Add(lblService);
            groupBoxSummary.Controls.Add(txtService);
            groupBoxSummary.Controls.Add(lblPartsSummary);
            groupBoxSummary.Controls.Add(txtPartsSummary);
            groupBoxSummary.Controls.Add(lblTax);
            groupBoxSummary.Controls.Add(txtTax);
            groupBoxSummary.Controls.Add(lblTotal);
            groupBoxSummary.Controls.Add(txtTotal);
            groupBoxSummary.Location = new Point(12, 252);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Size = new Size(496, 187);
            groupBoxSummary.TabIndex = 4;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "費用摘要";
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(12, 28);
            lblService.Name = "lblService";
            lblService.Size = new Size(112, 25);
            lblService.TabIndex = 0;
            lblService.Text = "服務與工資";
            // 
            // txtService
            // 
            txtService.Location = new Point(140, 24);
            txtService.Name = "txtService";
            txtService.ReadOnly = true;
            txtService.Size = new Size(301, 34);
            txtService.TabIndex = 1;
            // 
            // lblPartsSummary
            // 
            lblPartsSummary.AutoSize = true;
            lblPartsSummary.Location = new Point(12, 58);
            lblPartsSummary.Name = "lblPartsSummary";
            lblPartsSummary.Size = new Size(52, 25);
            lblPartsSummary.TabIndex = 2;
            lblPartsSummary.Text = "零件";
            // 
            // txtPartsSummary
            // 
            txtPartsSummary.Location = new Point(140, 54);
            txtPartsSummary.Name = "txtPartsSummary";
            txtPartsSummary.ReadOnly = true;
            txtPartsSummary.Size = new Size(306, 34);
            txtPartsSummary.TabIndex = 3;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(15, 83);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(109, 25);
            lblTax.TabIndex = 4;
            lblTax.Text = "稅金 (零件)";
            lblTax.Click += lblTax_Click;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(140, 83);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(306, 34);
            txtTax.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(15, 132);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(72, 25);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "總費用";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(131, 123);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(315, 34);
            txtTotal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(56, 455);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 32);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "計算總額";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(201, 455);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 32);
            btnClear.TabIndex = 6;
            btnClear.Text = "清除";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(321, 455);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            // 
            // Form1
            // 
            ClientSize = new Size(545, 564);
            Controls.Add(groupBoxOil);
            Controls.Add(groupBoxCleaning);
            Controls.Add(groupBoxOther);
            Controls.Add(groupBoxPartsLabor);
            Controls.Add(groupBoxSummary);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "汽車維修服務";
            groupBoxOil.ResumeLayout(false);
            groupBoxOil.PerformLayout();
            groupBoxCleaning.ResumeLayout(false);
            groupBoxCleaning.PerformLayout();
            groupBoxOther.ResumeLayout(false);
            groupBoxOther.PerformLayout();
            groupBoxPartsLabor.ResumeLayout(false);
            groupBoxPartsLabor.PerformLayout();
            groupBoxSummary.ResumeLayout(false);
            groupBoxSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}

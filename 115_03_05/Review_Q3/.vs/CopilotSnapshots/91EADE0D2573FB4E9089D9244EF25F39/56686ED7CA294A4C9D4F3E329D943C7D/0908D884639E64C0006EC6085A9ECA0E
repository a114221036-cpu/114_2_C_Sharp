namespace Review_Q3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel panelNumbers;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Label lblNumber4;
        private System.Windows.Forms.Label lblNumber5;
        private System.Windows.Forms.Label lblNumber6;

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnLoadWinningNumbers;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.ListBox lstWinningNumbers;
        private System.Windows.Forms.Label lblWinningNumbersTitle;

        private System.Windows.Forms.GroupBox grpCompareResult;
        private System.Windows.Forms.Label lblCompareResult;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "樂透號碼產生器";

            // Title
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "樂透號碼產生器";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);

            // Numbers panel
            this.panelNumbers = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNumbers.Name = "panelNumbers";
            this.panelNumbers.Location = new System.Drawing.Point(12, 60);
            this.panelNumbers.Size = new System.Drawing.Size(760, 100);
            this.panelNumbers.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelNumbers.WrapContents = false;
            this.panelNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Number labels (6 boxes)
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.lblNumber4 = new System.Windows.Forms.Label();
            this.lblNumber5 = new System.Windows.Forms.Label();
            this.lblNumber6 = new System.Windows.Forms.Label();

            System.Windows.Forms.Label[] numberLabels = new System.Windows.Forms.Label[] {
                this.lblNumber1, this.lblNumber2, this.lblNumber3,
                this.lblNumber4, this.lblNumber5, this.lblNumber6 };

            for (int i = 0; i < numberLabels.Length; i++)
            {
                var lbl = numberLabels[i];
                lbl.Name = "lblNumber" + (i + 1).ToString();
                lbl.Text = "--";
                lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lbl.Size = new System.Drawing.Size(100, 70);
                lbl.Margin = new System.Windows.Forms.Padding(10);
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panelNumbers.Controls.Add(lbl);
            }

            // Buttons
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Text = "產生號碼";
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Size = new System.Drawing.Size(160, 60);
            this.btnGenerate.Location = new System.Drawing.Point(12, 180);

            this.btnLoadWinningNumbers = new System.Windows.Forms.Button();
            this.btnLoadWinningNumbers.Name = "btnLoadWinningNumbers";
            this.btnLoadWinningNumbers.Text = "開獎號碼";
            this.btnLoadWinningNumbers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadWinningNumbers.Size = new System.Drawing.Size(160, 60);
            this.btnLoadWinningNumbers.Location = new System.Drawing.Point(190, 180);

            this.btnExit = new System.Windows.Forms.Button();
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "離開";
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Size = new System.Drawing.Size(160, 60);
            this.btnExit.Location = new System.Drawing.Point(368, 180);

            // Winning numbers list and title
            this.lblWinningNumbersTitle = new System.Windows.Forms.Label();
            this.lblWinningNumbersTitle.Name = "lblWinningNumbersTitle";
            this.lblWinningNumbersTitle.Text = "檔案開獎號碼";
            this.lblWinningNumbersTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWinningNumbersTitle.AutoSize = true;
            this.lblWinningNumbersTitle.Location = new System.Drawing.Point(12, 260);

            this.lstWinningNumbers = new System.Windows.Forms.ListBox();
            this.lstWinningNumbers.Name = "lstWinningNumbers";
            this.lstWinningNumbers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstWinningNumbers.Location = new System.Drawing.Point(12, 300);
            this.lstWinningNumbers.Size = new System.Drawing.Size(420, 130);

            // Compare result group
            this.grpCompareResult = new System.Windows.Forms.GroupBox();
            this.grpCompareResult.Name = "grpCompareResult";
            this.grpCompareResult.Text = "中獎比對結果";
            this.grpCompareResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCompareResult.Location = new System.Drawing.Point(450, 180);
            this.grpCompareResult.Size = new System.Drawing.Size(322, 250);

            this.lblCompareResult = new System.Windows.Forms.Label();
            this.lblCompareResult.Name = "lblCompareResult";
            this.lblCompareResult.Text = "請按下按鈕進行比對";
            this.lblCompareResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompareResult.AutoSize = false;
            this.lblCompareResult.Size = new System.Drawing.Size(300, 200);
            this.lblCompareResult.Location = new System.Drawing.Point(10, 30);
            this.lblCompareResult.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            this.grpCompareResult.Controls.Add(this.lblCompareResult);

            // Add controls to form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnLoadWinningNumbers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWinningNumbersTitle);
            this.Controls.Add(this.lstWinningNumbers);
            this.Controls.Add(this.grpCompareResult);
        }

        #endregion
    }
}

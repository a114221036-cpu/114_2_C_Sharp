namespace 摩斯密碼轉換器
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label labelFull;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelInput = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.labelFull = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.labelList = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();

            // Form
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(520, 420);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "摩斯密碼轉換";

            // labelInput
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 12);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(72, 16);
            this.labelInput.Text = "請輸入字串：";

            // inputTextBox
            this.inputTextBox.Location = new System.Drawing.Point(15, 30);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(490, 100);
            this.inputTextBox.Name = "inputTextBox";

            // labelFull
            this.labelFull.AutoSize = true;
            this.labelFull.Location = new System.Drawing.Point(12, 140);
            this.labelFull.Name = "labelFull";
            this.labelFull.Size = new System.Drawing.Size(104, 16);
            this.labelFull.Text = "完整摩斯密碼：";

            // outputTextBox
            this.outputTextBox.Location = new System.Drawing.Point(15, 158);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(490, 80);
            this.outputTextBox.Name = "outputTextBox";

            // labelList
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(12, 245);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(72, 16);
            this.labelList.Text = "逐字對照：";

            // listBox1
            this.listBox1.Location = new System.Drawing.Point(15, 263);
            this.listBox1.Size = new System.Drawing.Size(490, 95);
            this.listBox1.Name = "listBox1";

            // convertButton
            this.convertButton.Location = new System.Drawing.Point(320, 370);
            this.convertButton.Size = new System.Drawing.Size(90, 30);
            this.convertButton.Name = "convertButton";
            this.convertButton.Text = "轉換";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);

            // clearButton
            this.clearButton.Location = new System.Drawing.Point(415, 370);
            this.clearButton.Size = new System.Drawing.Size(90, 30);
            this.clearButton.Name = "clearButton";
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);

            // Add controls
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.labelFull);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.clearButton);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


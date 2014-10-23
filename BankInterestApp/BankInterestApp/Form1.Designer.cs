namespace BankInterestApp
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
            this.bankNameLebel = new System.Windows.Forms.Label();
            this.timeLebel = new System.Windows.Forms.Label();
            this.balanceLebel = new System.Windows.Forms.Label();
            this.interestLebel = new System.Windows.Forms.Label();
            this.interestResultLebel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bankNameLebel
            // 
            this.bankNameLebel.AutoSize = true;
            this.bankNameLebel.Location = new System.Drawing.Point(25, 26);
            this.bankNameLebel.Name = "bankNameLebel";
            this.bankNameLebel.Size = new System.Drawing.Size(68, 13);
            this.bankNameLebel.TabIndex = 0;
            this.bankNameLebel.Text = "Banks Name";
            // 
            // timeLebel
            // 
            this.timeLebel.AutoSize = true;
            this.timeLebel.Location = new System.Drawing.Point(25, 67);
            this.timeLebel.Name = "timeLebel";
            this.timeLebel.Size = new System.Drawing.Size(76, 13);
            this.timeLebel.TabIndex = 1;
            this.timeLebel.Text = "Time ( in year )";
            // 
            // balanceLebel
            // 
            this.balanceLebel.AutoSize = true;
            this.balanceLebel.Location = new System.Drawing.Point(25, 92);
            this.balanceLebel.Name = "balanceLebel";
            this.balanceLebel.Size = new System.Drawing.Size(46, 13);
            this.balanceLebel.TabIndex = 2;
            this.balanceLebel.Text = "Balance";
            // 
            // interestLebel
            // 
            this.interestLebel.AutoSize = true;
            this.interestLebel.Location = new System.Drawing.Point(39, 203);
            this.interestLebel.Name = "interestLebel";
            this.interestLebel.Size = new System.Drawing.Size(48, 13);
            this.interestLebel.TabIndex = 3;
            this.interestLebel.Text = "Interest=";
            // 
            // interestResultLebel
            // 
            this.interestResultLebel.AutoSize = true;
            this.interestResultLebel.Location = new System.Drawing.Point(121, 203);
            this.interestResultLebel.Name = "interestResultLebel";
            this.interestResultLebel.Size = new System.Drawing.Size(0, 13);
            this.interestResultLebel.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(96, 149);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Interest";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(108, 92);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BalanceTextBox.TabIndex = 6;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(108, 67);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 7;
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bankNameComboBox.Location = new System.Drawing.Point(108, 26);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.bankNameComboBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bankNameComboBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.interestResultLebel);
            this.Controls.Add(this.interestLebel);
            this.Controls.Add(this.balanceLebel);
            this.Controls.Add(this.timeLebel);
            this.Controls.Add(this.bankNameLebel);
            this.Name = "Form1";
            this.Text = "Interest Calculator Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bankNameLebel;
        private System.Windows.Forms.Label timeLebel;
        private System.Windows.Forms.Label balanceLebel;
        private System.Windows.Forms.Label interestLebel;
        private System.Windows.Forms.Label interestResultLebel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.ComboBox bankNameComboBox;
    }
}


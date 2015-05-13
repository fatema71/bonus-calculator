namespace BonusCalculatorApp
{
    partial class BonusCalculatorUI
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
            this.salaryLabel = new System.Windows.Forms.Label();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(63, 36);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 0;
            this.salaryLabel.Text = "Salary";
            // 
            // bonusLabel
            // 
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Location = new System.Drawing.Point(63, 72);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(37, 13);
            this.bonusLabel.TabIndex = 1;
            this.bonusLabel.Text = "Bonus";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(104, 36);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(136, 20);
            this.salaryTextBox.TabIndex = 2;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(104, 69);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(136, 20);
            this.bonusTextBox.TabIndex = 3;
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(126, 105);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(79, 23);
            this.resultButton.TabIndex = 4;
            this.resultButton.Text = "Show Bonus";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // BonusCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.bonusLabel);
            this.Controls.Add(this.salaryLabel);
            this.Name = "BonusCalculatorUI";
            this.Text = "      Bonus Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.Button resultButton;
    }
}


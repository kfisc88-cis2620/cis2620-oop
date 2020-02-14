namespace ex5b_CheckMonth
{
    partial class CheckMonth
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.birthMonthTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(55, 41);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(210, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Please enter a the number of a birth month:";
            // 
            // birthMonthTextBox
            // 
            this.birthMonthTextBox.Location = new System.Drawing.Point(58, 78);
            this.birthMonthTextBox.Name = "birthMonthTextBox";
            this.birthMonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthMonthTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(190, 75);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(55, 135);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(210, 42);
            this.outputLabel.TabIndex = 3;
            // 
            // CheckMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 231);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.birthMonthTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "CheckMonth";
            this.Text = "Check Month";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox birthMonthTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label outputLabel;
    }
}


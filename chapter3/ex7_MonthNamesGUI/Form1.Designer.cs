namespace ex7_MonthNamesGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.userPromptLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.displayMonthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(185, 27);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 0;
            // 
            // userPromptLabel
            // 
            this.userPromptLabel.AutoSize = true;
            this.userPromptLabel.Location = new System.Drawing.Point(12, 30);
            this.userPromptLabel.Name = "userPromptLabel";
            this.userPromptLabel.Size = new System.Drawing.Size(153, 13);
            this.userPromptLabel.TabIndex = 1;
            this.userPromptLabel.Text = "Enter the number of the month:";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(12, 70);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(147, 26);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display Month";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // displayMonthLabel
            // 
            this.displayMonthLabel.AutoSize = true;
            this.displayMonthLabel.Location = new System.Drawing.Point(182, 77);
            this.displayMonthLabel.Name = "displayMonthLabel";
            this.displayMonthLabel.Size = new System.Drawing.Size(0, 13);
            this.displayMonthLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(314, 131);
            this.Controls.Add(this.displayMonthLabel);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.userPromptLabel);
            this.Controls.Add(this.monthTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label userPromptLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label displayMonthLabel;
    }
}


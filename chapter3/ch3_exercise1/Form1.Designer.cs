namespace ch3_exercise1
{
    partial class InchesToCentimetersGUI
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
            this.inchesLabel = new System.Windows.Forms.Label();
            this.getInchesTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.cmConvertLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Location = new System.Drawing.Point(25, 55);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(90, 13);
            this.inchesLabel.TabIndex = 0;
            this.inchesLabel.Text = "Enter the inches: ";
            // 
            // getInchesTextBox
            // 
            this.getInchesTextBox.Location = new System.Drawing.Point(150, 50);
            this.getInchesTextBox.Name = "getInchesTextBox";
            this.getInchesTextBox.Size = new System.Drawing.Size(100, 20);
            this.getInchesTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(28, 114);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // cmConvertLabel
            // 
            this.cmConvertLabel.AutoSize = true;
            this.cmConvertLabel.Location = new System.Drawing.Point(147, 119);
            this.cmConvertLabel.Name = "cmConvertLabel";
            this.cmConvertLabel.Size = new System.Drawing.Size(0, 13);
            this.cmConvertLabel.TabIndex = 3;
            // 
            // InchesToCentimetersGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.cmConvertLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.getInchesTextBox);
            this.Controls.Add(this.inchesLabel);
            this.Name = "InchesToCentimetersGUI";
            this.Text = "Inches to Centimeters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.TextBox getInchesTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label cmConvertLabel;
    }
}


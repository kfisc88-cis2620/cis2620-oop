namespace ex3_MoveEstimatorGUI
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
            this.hoursLabel = new System.Windows.Forms.Label();
            this.milesLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.baseRateLabel = new System.Windows.Forms.Label();
            this.hoursRateLabel = new System.Windows.Forms.Label();
            this.baseChargesLabel = new System.Windows.Forms.Label();
            this.hoursChargeLabel = new System.Windows.Forms.Label();
            this.milesRateLabel = new System.Windows.Forms.Label();
            this.milesChargeLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(55, 31);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(56, 22);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "Hours:";
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesLabel.Location = new System.Drawing.Point(61, 78);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(50, 22);
            this.milesLabel.TabIndex = 1;
            this.milesLabel.Text = "Miles:";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextBox.Location = new System.Drawing.Point(117, 24);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 29);
            this.hoursTextBox.TabIndex = 2;
            // 
            // milesTextBox
            // 
            this.milesTextBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesTextBox.Location = new System.Drawing.Point(117, 71);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(100, 29);
            this.milesTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(83, 125);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(117, 47);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // baseRateLabel
            // 
            this.baseRateLabel.AutoSize = true;
            this.baseRateLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseRateLabel.Location = new System.Drawing.Point(71, 197);
            this.baseRateLabel.Name = "baseRateLabel";
            this.baseRateLabel.Size = new System.Drawing.Size(79, 22);
            this.baseRateLabel.TabIndex = 5;
            this.baseRateLabel.Text = "Base Rate:";
            // 
            // hoursRateLabel
            // 
            this.hoursRateLabel.AutoSize = true;
            this.hoursRateLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursRateLabel.Location = new System.Drawing.Point(27, 232);
            this.hoursRateLabel.Name = "hoursRateLabel";
            this.hoursRateLabel.Size = new System.Drawing.Size(123, 22);
            this.hoursRateLabel.TabIndex = 6;
            this.hoursRateLabel.Text = "Hourly Charges:";
            // 
            // baseChargesLabel
            // 
            this.baseChargesLabel.AutoSize = true;
            this.baseChargesLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseChargesLabel.Location = new System.Drawing.Point(176, 197);
            this.baseChargesLabel.Name = "baseChargesLabel";
            this.baseChargesLabel.Size = new System.Drawing.Size(62, 22);
            this.baseChargesLabel.TabIndex = 7;
            this.baseChargesLabel.Text = "$200.00";
            // 
            // hoursChargeLabel
            // 
            this.hoursChargeLabel.AutoSize = true;
            this.hoursChargeLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursChargeLabel.Location = new System.Drawing.Point(176, 232);
            this.hoursChargeLabel.Name = "hoursChargeLabel";
            this.hoursChargeLabel.Size = new System.Drawing.Size(0, 22);
            this.hoursChargeLabel.TabIndex = 8;
            // 
            // milesRateLabel
            // 
            this.milesRateLabel.AutoSize = true;
            this.milesRateLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesRateLabel.Location = new System.Drawing.Point(22, 267);
            this.milesRateLabel.Name = "milesRateLabel";
            this.milesRateLabel.Size = new System.Drawing.Size(128, 22);
            this.milesRateLabel.TabIndex = 9;
            this.milesRateLabel.Text = "Mileage Charges:";
            // 
            // milesChargeLabel
            // 
            this.milesChargeLabel.AutoSize = true;
            this.milesChargeLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesChargeLabel.Location = new System.Drawing.Point(176, 267);
            this.milesChargeLabel.Name = "milesChargeLabel";
            this.milesChargeLabel.Size = new System.Drawing.Size(0, 22);
            this.milesChargeLabel.TabIndex = 10;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(101, 302);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 22);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total:";
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.AutoSize = true;
            this.totalChargesLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalChargesLabel.Location = new System.Drawing.Point(176, 302);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(0, 22);
            this.totalChargesLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 369);
            this.Controls.Add(this.totalChargesLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.milesChargeLabel);
            this.Controls.Add(this.milesRateLabel);
            this.Controls.Add(this.hoursChargeLabel);
            this.Controls.Add(this.baseChargesLabel);
            this.Controls.Add(this.hoursRateLabel);
            this.Controls.Add(this.baseRateLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.milesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Moving Cost Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label baseRateLabel;
        private System.Windows.Forms.Label hoursRateLabel;
        private System.Windows.Forms.Label baseChargesLabel;
        private System.Windows.Forms.Label hoursChargeLabel;
        private System.Windows.Forms.Label milesRateLabel;
        private System.Windows.Forms.Label milesChargeLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalChargesLabel;
    }
}


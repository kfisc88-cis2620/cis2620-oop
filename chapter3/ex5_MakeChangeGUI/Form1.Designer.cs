namespace ex5_MakeChangeGUI
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
            this.userPromptLabel1 = new System.Windows.Forms.Label();
            this.dollarTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.twentyLabel = new System.Windows.Forms.Label();
            this.tenLabel = new System.Windows.Forms.Label();
            this.fiveLabel = new System.Windows.Forms.Label();
            this.oneLabel = new System.Windows.Forms.Label();
            this.twentyNumberLabel = new System.Windows.Forms.Label();
            this.tenNumberLabel = new System.Windows.Forms.Label();
            this.fiveNumberLabel = new System.Windows.Forms.Label();
            this.oneNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userPromptLabel1
            // 
            this.userPromptLabel1.AutoSize = true;
            this.userPromptLabel1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPromptLabel1.Location = new System.Drawing.Point(9, 26);
            this.userPromptLabel1.Name = "userPromptLabel1";
            this.userPromptLabel1.Size = new System.Drawing.Size(189, 19);
            this.userPromptLabel1.TabIndex = 0;
            this.userPromptLabel1.Text = "Enter a whole dollar amount:";
            // 
            // dollarTextBox
            // 
            this.dollarTextBox.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarTextBox.Location = new System.Drawing.Point(12, 48);
            this.dollarTextBox.Name = "dollarTextBox";
            this.dollarTextBox.Size = new System.Drawing.Size(100, 26);
            this.dollarTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(12, 89);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 31);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // twentyLabel
            // 
            this.twentyLabel.AutoSize = true;
            this.twentyLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twentyLabel.Location = new System.Drawing.Point(168, 74);
            this.twentyLabel.Name = "twentyLabel";
            this.twentyLabel.Size = new System.Drawing.Size(43, 19);
            this.twentyLabel.TabIndex = 5;
            this.twentyLabel.Text = "$20s:";
            // 
            // tenLabel
            // 
            this.tenLabel.AutoSize = true;
            this.tenLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenLabel.Location = new System.Drawing.Point(168, 99);
            this.tenLabel.Name = "tenLabel";
            this.tenLabel.Size = new System.Drawing.Size(41, 19);
            this.tenLabel.TabIndex = 6;
            this.tenLabel.Text = "$10s:";
            // 
            // fiveLabel
            // 
            this.fiveLabel.AutoSize = true;
            this.fiveLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveLabel.Location = new System.Drawing.Point(174, 124);
            this.fiveLabel.Name = "fiveLabel";
            this.fiveLabel.Size = new System.Drawing.Size(35, 19);
            this.fiveLabel.TabIndex = 7;
            this.fiveLabel.Text = "$5s:";
            // 
            // oneLabel
            // 
            this.oneLabel.AutoSize = true;
            this.oneLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneLabel.Location = new System.Drawing.Point(174, 149);
            this.oneLabel.Name = "oneLabel";
            this.oneLabel.Size = new System.Drawing.Size(33, 19);
            this.oneLabel.TabIndex = 8;
            this.oneLabel.Text = "$1s:";
            // 
            // twentyNumberLabel
            // 
            this.twentyNumberLabel.AutoSize = true;
            this.twentyNumberLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twentyNumberLabel.Location = new System.Drawing.Point(224, 74);
            this.twentyNumberLabel.Name = "twentyNumberLabel";
            this.twentyNumberLabel.Size = new System.Drawing.Size(0, 19);
            this.twentyNumberLabel.TabIndex = 11;
            // 
            // tenNumberLabel
            // 
            this.tenNumberLabel.AutoSize = true;
            this.tenNumberLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNumberLabel.Location = new System.Drawing.Point(224, 99);
            this.tenNumberLabel.Name = "tenNumberLabel";
            this.tenNumberLabel.Size = new System.Drawing.Size(0, 19);
            this.tenNumberLabel.TabIndex = 12;
            // 
            // fiveNumberLabel
            // 
            this.fiveNumberLabel.AutoSize = true;
            this.fiveNumberLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveNumberLabel.Location = new System.Drawing.Point(224, 124);
            this.fiveNumberLabel.Name = "fiveNumberLabel";
            this.fiveNumberLabel.Size = new System.Drawing.Size(0, 19);
            this.fiveNumberLabel.TabIndex = 13;
            // 
            // oneNumberLabel
            // 
            this.oneNumberLabel.AutoSize = true;
            this.oneNumberLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneNumberLabel.Location = new System.Drawing.Point(224, 149);
            this.oneNumberLabel.Name = "oneNumberLabel";
            this.oneNumberLabel.Size = new System.Drawing.Size(0, 19);
            this.oneNumberLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(301, 194);
            this.Controls.Add(this.oneNumberLabel);
            this.Controls.Add(this.fiveNumberLabel);
            this.Controls.Add(this.tenNumberLabel);
            this.Controls.Add(this.twentyNumberLabel);
            this.Controls.Add(this.oneLabel);
            this.Controls.Add(this.fiveLabel);
            this.Controls.Add(this.tenLabel);
            this.Controls.Add(this.twentyLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dollarTextBox);
            this.Controls.Add(this.userPromptLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userPromptLabel1;
        private System.Windows.Forms.TextBox dollarTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label twentyLabel;
        private System.Windows.Forms.Label tenLabel;
        private System.Windows.Forms.Label fiveLabel;
        private System.Windows.Forms.Label oneLabel;
        private System.Windows.Forms.Label twentyNumberLabel;
        private System.Windows.Forms.Label tenNumberLabel;
        private System.Windows.Forms.Label fiveNumberLabel;
        private System.Windows.Forms.Label oneNumberLabel;
    }
}


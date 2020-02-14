namespace ex9_Lottery
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
            this.guessLabel1 = new System.Windows.Forms.Label();
            this.guessLabel2 = new System.Windows.Forms.Label();
            this.guessLabel3 = new System.Windows.Forms.Label();
            this.guess1TextBox = new System.Windows.Forms.TextBox();
            this.guess2TextBox = new System.Windows.Forms.TextBox();
            this.guess3TextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.match1Label = new System.Windows.Forms.Label();
            this.match2Label = new System.Windows.Forms.Label();
            this.match3Label = new System.Windows.Forms.Label();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.prizeOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessLabel1
            // 
            this.guessLabel1.AutoSize = true;
            this.guessLabel1.Location = new System.Drawing.Point(12, 32);
            this.guessLabel1.Name = "guessLabel1";
            this.guessLabel1.Size = new System.Drawing.Size(89, 13);
            this.guessLabel1.TabIndex = 0;
            this.guessLabel1.Text = "Guess Number 1:";
            // 
            // guessLabel2
            // 
            this.guessLabel2.AutoSize = true;
            this.guessLabel2.Location = new System.Drawing.Point(12, 55);
            this.guessLabel2.Name = "guessLabel2";
            this.guessLabel2.Size = new System.Drawing.Size(89, 13);
            this.guessLabel2.TabIndex = 1;
            this.guessLabel2.Text = "Guess Number 2:";
            // 
            // guessLabel3
            // 
            this.guessLabel3.AutoSize = true;
            this.guessLabel3.Location = new System.Drawing.Point(12, 81);
            this.guessLabel3.Name = "guessLabel3";
            this.guessLabel3.Size = new System.Drawing.Size(89, 13);
            this.guessLabel3.TabIndex = 2;
            this.guessLabel3.Text = "Guess Number 3:";
            // 
            // guess1TextBox
            // 
            this.guess1TextBox.Location = new System.Drawing.Point(107, 29);
            this.guess1TextBox.Name = "guess1TextBox";
            this.guess1TextBox.Size = new System.Drawing.Size(32, 20);
            this.guess1TextBox.TabIndex = 3;
            // 
            // guess2TextBox
            // 
            this.guess2TextBox.Location = new System.Drawing.Point(107, 55);
            this.guess2TextBox.Name = "guess2TextBox";
            this.guess2TextBox.Size = new System.Drawing.Size(32, 20);
            this.guess2TextBox.TabIndex = 4;
            // 
            // guess3TextBox
            // 
            this.guess3TextBox.Location = new System.Drawing.Point(107, 81);
            this.guess3TextBox.Name = "guess3TextBox";
            this.guess3TextBox.Size = new System.Drawing.Size(32, 20);
            this.guess3TextBox.TabIndex = 5;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(69, 124);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check!";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // match1Label
            // 
            this.match1Label.Location = new System.Drawing.Point(145, 29);
            this.match1Label.Name = "match1Label";
            this.match1Label.Size = new System.Drawing.Size(58, 20);
            this.match1Label.TabIndex = 7;
            // 
            // match2Label
            // 
            this.match2Label.Location = new System.Drawing.Point(145, 58);
            this.match2Label.Name = "match2Label";
            this.match2Label.Size = new System.Drawing.Size(58, 17);
            this.match2Label.TabIndex = 8;
            // 
            // match3Label
            // 
            this.match3Label.Location = new System.Drawing.Point(145, 84);
            this.match3Label.Name = "match3Label";
            this.match3Label.Size = new System.Drawing.Size(58, 17);
            this.match3Label.TabIndex = 9;
            // 
            // prizeLabel
            // 
            this.prizeLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeLabel.Location = new System.Drawing.Point(12, 191);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(245, 109);
            this.prizeLabel.TabIndex = 10;
            this.prizeLabel.Text = resources.GetString("prizeLabel.Text");
            // 
            // prizeOutputLabel
            // 
            this.prizeOutputLabel.Location = new System.Drawing.Point(219, 9);
            this.prizeOutputLabel.Name = "prizeOutputLabel";
            this.prizeOutputLabel.Size = new System.Drawing.Size(196, 79);
            this.prizeOutputLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 309);
            this.Controls.Add(this.prizeOutputLabel);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.match3Label);
            this.Controls.Add(this.match2Label);
            this.Controls.Add(this.match1Label);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.guess3TextBox);
            this.Controls.Add(this.guess2TextBox);
            this.Controls.Add(this.guess1TextBox);
            this.Controls.Add(this.guessLabel3);
            this.Controls.Add(this.guessLabel2);
            this.Controls.Add(this.guessLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guessLabel1;
        private System.Windows.Forms.Label guessLabel2;
        private System.Windows.Forms.Label guessLabel3;
        private System.Windows.Forms.TextBox guess1TextBox;
        private System.Windows.Forms.TextBox guess2TextBox;
        private System.Windows.Forms.TextBox guess3TextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label match1Label;
        private System.Windows.Forms.Label match2Label;
        private System.Windows.Forms.Label match3Label;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.Label prizeOutputLabel;
    }
}


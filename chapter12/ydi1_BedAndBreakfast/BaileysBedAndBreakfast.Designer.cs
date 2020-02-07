namespace ydi1_BedAndBreakfast
{
    partial class BaileysForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.belleAireCheckbox = new System.Windows.Forms.CheckBox();
            this.lincolnCheckbox = new System.Windows.Forms.CheckBox();
            this.mealButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(77, 44);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(248, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Bailey\'s";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(116, 91);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(164, 25);
            this.rateLabel.TabIndex = 1;
            this.rateLabel.Text = "Check our rates";
            // 
            // belleAireCheckbox
            // 
            this.belleAireCheckbox.AutoSize = true;
            this.belleAireCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belleAireCheckbox.Location = new System.Drawing.Point(121, 136);
            this.belleAireCheckbox.Name = "belleAireCheckbox";
            this.belleAireCheckbox.Size = new System.Drawing.Size(173, 28);
            this.belleAireCheckbox.TabIndex = 2;
            this.belleAireCheckbox.Text = "Belle Aire Suite";
            this.belleAireCheckbox.UseVisualStyleBackColor = true;
            this.belleAireCheckbox.CheckedChanged += new System.EventHandler(this.BelleAireCheckbox_CheckedChanged);
            // 
            // lincolnCheckbox
            // 
            this.lincolnCheckbox.AutoSize = true;
            this.lincolnCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lincolnCheckbox.Location = new System.Drawing.Point(121, 180);
            this.lincolnCheckbox.Name = "lincolnCheckbox";
            this.lincolnCheckbox.Size = new System.Drawing.Size(158, 28);
            this.lincolnCheckbox.TabIndex = 3;
            this.lincolnCheckbox.Text = "Lincoln Room";
            this.lincolnCheckbox.UseVisualStyleBackColor = true;
            this.lincolnCheckbox.CheckedChanged += new System.EventHandler(this.lincolnCheckbox_CheckedChanged);
            // 
            // mealButton
            // 
            this.mealButton.Location = new System.Drawing.Point(12, 283);
            this.mealButton.Name = "mealButton";
            this.mealButton.Size = new System.Drawing.Size(160, 23);
            this.mealButton.TabIndex = 4;
            this.mealButton.Text = "Click for meal options";
            this.mealButton.UseVisualStyleBackColor = true;
            this.mealButton.Click += new System.EventHandler(this.mealButton_Click);
            // 
            // BaileysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(428, 318);
            this.Controls.Add(this.mealButton);
            this.Controls.Add(this.lincolnCheckbox);
            this.Controls.Add(this.belleAireCheckbox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "BaileysForm";
            this.Text = "Bailey\'s Bed and Breakfast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.CheckBox belleAireCheckbox;
        private System.Windows.Forms.CheckBox lincolnCheckbox;
        private System.Windows.Forms.Button mealButton;
    }
}


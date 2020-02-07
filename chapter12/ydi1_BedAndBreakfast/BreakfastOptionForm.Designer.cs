namespace ydi1_BedAndBreakfast
{
    partial class BreakfastOptionForm
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
            this.contRadioButton = new System.Windows.Forms.RadioButton();
            this.fullRadioButton = new System.Windows.Forms.RadioButton();
            this.deluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.breakfastPromptLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contRadioButton
            // 
            this.contRadioButton.AutoSize = true;
            this.contRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contRadioButton.Location = new System.Drawing.Point(148, 78);
            this.contRadioButton.Name = "contRadioButton";
            this.contRadioButton.Size = new System.Drawing.Size(119, 29);
            this.contRadioButton.TabIndex = 0;
            this.contRadioButton.TabStop = true;
            this.contRadioButton.Text = "Continental";
            this.contRadioButton.UseVisualStyleBackColor = true;
            this.contRadioButton.CheckedChanged += new System.EventHandler(this.ContRadioButton_CheckedChanged);
            // 
            // fullRadioButton
            // 
            this.fullRadioButton.AutoSize = true;
            this.fullRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullRadioButton.Location = new System.Drawing.Point(148, 113);
            this.fullRadioButton.Name = "fullRadioButton";
            this.fullRadioButton.Size = new System.Drawing.Size(62, 29);
            this.fullRadioButton.TabIndex = 1;
            this.fullRadioButton.TabStop = true;
            this.fullRadioButton.Text = "Full";
            this.fullRadioButton.UseVisualStyleBackColor = true;
            this.fullRadioButton.CheckedChanged += new System.EventHandler(this.FullRadioButton_CheckedChanged);
            // 
            // deluxeRadioButton
            // 
            this.deluxeRadioButton.AutoSize = true;
            this.deluxeRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deluxeRadioButton.Location = new System.Drawing.Point(148, 148);
            this.deluxeRadioButton.Name = "deluxeRadioButton";
            this.deluxeRadioButton.Size = new System.Drawing.Size(84, 29);
            this.deluxeRadioButton.TabIndex = 2;
            this.deluxeRadioButton.TabStop = true;
            this.deluxeRadioButton.Text = "Deluxe";
            this.deluxeRadioButton.UseVisualStyleBackColor = true;
            this.deluxeRadioButton.CheckedChanged += new System.EventHandler(this.DeluxeRadioButton_CheckedChanged);
            // 
            // breakfastPromptLabel
            // 
            this.breakfastPromptLabel.AutoSize = true;
            this.breakfastPromptLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastPromptLabel.Location = new System.Drawing.Point(70, 34);
            this.breakfastPromptLabel.Name = "breakfastPromptLabel";
            this.breakfastPromptLabel.Size = new System.Drawing.Size(224, 25);
            this.breakfastPromptLabel.TabIndex = 3;
            this.breakfastPromptLabel.Text = "Select your breakfast option:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(172, 205);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(60, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price:";
            // 
            // BreakfastOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(377, 295);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.breakfastPromptLabel);
            this.Controls.Add(this.deluxeRadioButton);
            this.Controls.Add(this.fullRadioButton);
            this.Controls.Add(this.contRadioButton);
            this.Name = "BreakfastOptionForm";
            this.Text = "BreakfastOptionForm";
            this.Load += new System.EventHandler(this.BreakfastOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton contRadioButton;
        private System.Windows.Forms.RadioButton fullRadioButton;
        private System.Windows.Forms.RadioButton deluxeRadioButton;
        private System.Windows.Forms.Label breakfastPromptLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}
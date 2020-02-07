namespace ex4_MyFlix
{
    partial class MyFlixForm
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
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.moviesLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.chooseButton = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moviesListBox
            // 
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Items.AddRange(new object[] {
            "Star Trek",
            "Interstellar",
            "The Martian",
            "Avatar",
            "Lost In Space",
            "Armageddon",
            "Guardians of the Galaxy"});
            this.moviesListBox.Location = new System.Drawing.Point(15, 41);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.moviesListBox.Size = new System.Drawing.Size(132, 95);
            this.moviesListBox.TabIndex = 0;
            this.moviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // moviesLabel
            // 
            this.moviesLabel.AutoSize = true;
            this.moviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesLabel.Location = new System.Drawing.Point(12, 9);
            this.moviesLabel.Name = "moviesLabel";
            this.moviesLabel.Size = new System.Drawing.Size(315, 16);
            this.moviesLabel.TabIndex = 1;
            this.moviesLabel.Text = "Choose your movies (select multiple by holding ctrl):\r\n";
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(349, 235);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(15, 142);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(132, 23);
            this.chooseButton.TabIndex = 3;
            this.chooseButton.Text = "Choose Selected";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.Location = new System.Drawing.Point(153, 41);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(196, 171);
            this.confirmLabel.TabIndex = 4;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(153, 212);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total:";
            // 
            // MyFlixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 270);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.moviesLabel);
            this.Controls.Add(this.moviesListBox);
            this.Name = "MyFlixForm";
            this.Text = "My Flix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.Label moviesLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}


namespace ex7_VacationPlanner
{
    partial class VacationPlanner
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
            this.basicRadioButton = new System.Windows.Forms.RadioButton();
            this.deluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.premiumRadioButton = new System.Windows.Forms.RadioButton();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.roomTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.petsCheckBox = new System.Windows.Forms.CheckBox();
            this.earlyCheckinCheckBox = new System.Windows.Forms.CheckBox();
            this.roomServiceCheckBox = new System.Windows.Forms.CheckBox();
            this.hotTubCheckBox = new System.Windows.Forms.CheckBox();
            this.mealPlanGroupBox = new System.Windows.Forms.GroupBox();
            this.deptCityLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.dummyButton = new System.Windows.Forms.Button();
            this.roomTypeGroupBox.SuspendLayout();
            this.mealPlanGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // basicRadioButton
            // 
            this.basicRadioButton.AutoSize = true;
            this.basicRadioButton.Location = new System.Drawing.Point(6, 18);
            this.basicRadioButton.Name = "basicRadioButton";
            this.basicRadioButton.Size = new System.Drawing.Size(53, 20);
            this.basicRadioButton.TabIndex = 0;
            this.basicRadioButton.TabStop = true;
            this.basicRadioButton.Text = "Basic";
            this.basicRadioButton.UseVisualStyleBackColor = true;
            // 
            // deluxeRadioButton
            // 
            this.deluxeRadioButton.AutoSize = true;
            this.deluxeRadioButton.Location = new System.Drawing.Point(6, 42);
            this.deluxeRadioButton.Name = "deluxeRadioButton";
            this.deluxeRadioButton.Size = new System.Drawing.Size(64, 20);
            this.deluxeRadioButton.TabIndex = 1;
            this.deluxeRadioButton.TabStop = true;
            this.deluxeRadioButton.Text = "Deluxe";
            this.deluxeRadioButton.UseVisualStyleBackColor = true;
            // 
            // premiumRadioButton
            // 
            this.premiumRadioButton.AutoSize = true;
            this.premiumRadioButton.Location = new System.Drawing.Point(6, 65);
            this.premiumRadioButton.Name = "premiumRadioButton";
            this.premiumRadioButton.Size = new System.Drawing.Size(76, 20);
            this.premiumRadioButton.TabIndex = 2;
            this.premiumRadioButton.TabStop = true;
            this.premiumRadioButton.Text = "Premium";
            this.premiumRadioButton.UseVisualStyleBackColor = true;
            // 
            // cityListBox
            // 
            this.cityListBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.ItemHeight = 16;
            this.cityListBox.Items.AddRange(new object[] {
            "Atlanta (ATL)",
            "Los Angeles (LAX)",
            "Chicago (ORD)",
            "Dallas (DFW)",
            "Denver (DEN)",
            "New York (JFK)",
            "Minneapolis (MSP)"});
            this.cityListBox.Location = new System.Drawing.Point(13, 100);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(120, 132);
            this.cityListBox.TabIndex = 4;
            // 
            // roomTypeGroupBox
            // 
            this.roomTypeGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.roomTypeGroupBox.Controls.Add(this.petsCheckBox);
            this.roomTypeGroupBox.Controls.Add(this.earlyCheckinCheckBox);
            this.roomTypeGroupBox.Controls.Add(this.roomServiceCheckBox);
            this.roomTypeGroupBox.Controls.Add(this.hotTubCheckBox);
            this.roomTypeGroupBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeGroupBox.Location = new System.Drawing.Point(320, 100);
            this.roomTypeGroupBox.Name = "roomTypeGroupBox";
            this.roomTypeGroupBox.Size = new System.Drawing.Size(179, 134);
            this.roomTypeGroupBox.TabIndex = 5;
            this.roomTypeGroupBox.TabStop = false;
            this.roomTypeGroupBox.Text = "Room Amenities";
            // 
            // petsCheckBox
            // 
            this.petsCheckBox.AutoSize = true;
            this.petsCheckBox.Location = new System.Drawing.Point(6, 88);
            this.petsCheckBox.Name = "petsCheckBox";
            this.petsCheckBox.Size = new System.Drawing.Size(48, 20);
            this.petsCheckBox.TabIndex = 3;
            this.petsCheckBox.Text = "Pets";
            this.petsCheckBox.UseVisualStyleBackColor = true;
            // 
            // earlyCheckinCheckBox
            // 
            this.earlyCheckinCheckBox.AutoSize = true;
            this.earlyCheckinCheckBox.Location = new System.Drawing.Point(6, 65);
            this.earlyCheckinCheckBox.Name = "earlyCheckinCheckBox";
            this.earlyCheckinCheckBox.Size = new System.Drawing.Size(108, 20);
            this.earlyCheckinCheckBox.TabIndex = 2;
            this.earlyCheckinCheckBox.Text = "Early Check-in";
            this.earlyCheckinCheckBox.UseVisualStyleBackColor = true;
            // 
            // roomServiceCheckBox
            // 
            this.roomServiceCheckBox.AutoSize = true;
            this.roomServiceCheckBox.Location = new System.Drawing.Point(6, 42);
            this.roomServiceCheckBox.Name = "roomServiceCheckBox";
            this.roomServiceCheckBox.Size = new System.Drawing.Size(105, 20);
            this.roomServiceCheckBox.TabIndex = 1;
            this.roomServiceCheckBox.Text = "Room Service";
            this.roomServiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // hotTubCheckBox
            // 
            this.hotTubCheckBox.AutoSize = true;
            this.hotTubCheckBox.Location = new System.Drawing.Point(6, 19);
            this.hotTubCheckBox.Name = "hotTubCheckBox";
            this.hotTubCheckBox.Size = new System.Drawing.Size(75, 20);
            this.hotTubCheckBox.TabIndex = 0;
            this.hotTubCheckBox.Text = "Hot Tub";
            this.hotTubCheckBox.UseVisualStyleBackColor = true;
            // 
            // mealPlanGroupBox
            // 
            this.mealPlanGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mealPlanGroupBox.Controls.Add(this.basicRadioButton);
            this.mealPlanGroupBox.Controls.Add(this.deluxeRadioButton);
            this.mealPlanGroupBox.Controls.Add(this.premiumRadioButton);
            this.mealPlanGroupBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealPlanGroupBox.Location = new System.Drawing.Point(161, 100);
            this.mealPlanGroupBox.Name = "mealPlanGroupBox";
            this.mealPlanGroupBox.Size = new System.Drawing.Size(131, 134);
            this.mealPlanGroupBox.TabIndex = 6;
            this.mealPlanGroupBox.TabStop = false;
            this.mealPlanGroupBox.Text = "Meal Plan";
            // 
            // deptCityLabel
            // 
            this.deptCityLabel.AutoSize = true;
            this.deptCityLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptCityLabel.Location = new System.Drawing.Point(13, 81);
            this.deptCityLabel.Name = "deptCityLabel";
            this.deptCityLabel.Size = new System.Drawing.Size(91, 16);
            this.deptCityLabel.TabIndex = 7;
            this.deptCityLabel.Text = "Departure City";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 18);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(362, 48);
            this.welcomeLabel.TabIndex = 8;
            this.welcomeLabel.Text = "Customize your experience with the following options:";
            // 
            // dummyButton
            // 
            this.dummyButton.BackColor = System.Drawing.SystemColors.Control;
            this.dummyButton.Location = new System.Drawing.Point(436, 261);
            this.dummyButton.Name = "dummyButton";
            this.dummyButton.Size = new System.Drawing.Size(75, 23);
            this.dummyButton.TabIndex = 9;
            this.dummyButton.Text = "Submit";
            this.dummyButton.UseVisualStyleBackColor = false;
            // 
            // VacationPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(523, 296);
            this.Controls.Add(this.dummyButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.deptCityLabel);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.mealPlanGroupBox);
            this.Controls.Add(this.roomTypeGroupBox);
            this.Name = "VacationPlanner";
            this.Text = "Vacation Planner";
            this.roomTypeGroupBox.ResumeLayout(false);
            this.roomTypeGroupBox.PerformLayout();
            this.mealPlanGroupBox.ResumeLayout(false);
            this.mealPlanGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton basicRadioButton;
        private System.Windows.Forms.RadioButton deluxeRadioButton;
        private System.Windows.Forms.RadioButton premiumRadioButton;
        private System.Windows.Forms.ListBox cityListBox;
        private System.Windows.Forms.GroupBox roomTypeGroupBox;
        private System.Windows.Forms.CheckBox petsCheckBox;
        private System.Windows.Forms.CheckBox earlyCheckinCheckBox;
        private System.Windows.Forms.CheckBox roomServiceCheckBox;
        private System.Windows.Forms.CheckBox hotTubCheckBox;
        private System.Windows.Forms.GroupBox mealPlanGroupBox;
        private System.Windows.Forms.Label deptCityLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button dummyButton;
    }
}


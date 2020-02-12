using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4_Hurricane
{
    public partial class Hurricane : Form
    {
        const int CATEGORY_5 = 157,
            CATEGORY_4 = 130,
            CATEGORY_3 = 111,
            CATEGORY_2 = 96,
            CATEGORY_1 = 74;

        public Hurricane()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int windSpeed = Convert.ToInt32(windSpeedTextBox.Text);
            if (windSpeed >= CATEGORY_5)
                outputLabel.Text = "Category 5 Hurricane.";
            else if (windSpeed >= CATEGORY_4 && windSpeed < CATEGORY_5)
                outputLabel.Text = "Category 4 Hurricane";
            else if (windSpeed >= CATEGORY_3 && windSpeed < CATEGORY_4)
                outputLabel.Text = "Category 3 Hurricane";
            else if (windSpeed >= CATEGORY_2 && windSpeed < CATEGORY_3)
                outputLabel.Text = "Category 2 Hurricane";
            else if (windSpeed >= CATEGORY_1 && windSpeed < CATEGORY_2)
                outputLabel.Text = "Category 1 Hurricane";
            else
                outputLabel.Text = "Calmn down, not a hurricane.";
        }
    }
}

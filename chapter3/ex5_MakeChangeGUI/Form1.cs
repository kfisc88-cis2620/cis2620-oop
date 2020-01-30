// Filename: ex5_MakeChangeGUI.csproj
// Written by: Kelley Fischer
// Written on: 01/29/20
// Description: 
//      Chapter 3 - Exercise 5
//      User enters a whole dollar amount and the program returns the amount of 
//      each bill required to make that amount.
// Encountered Issues: None;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5_MakeChangeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int dollarAmount;

            dollarAmount = Convert.ToInt32(dollarTextBox.Text);

            twentyNumberLabel.Text = (dollarAmount / 20).ToString();
            dollarAmount -= (20 * Convert.ToInt32(twentyNumberLabel.Text));

            tenNumberLabel.Text = (dollarAmount / 10).ToString();
            dollarAmount -= (10 * Convert.ToInt32(tenNumberLabel.Text));

            fiveNumberLabel.Text = (dollarAmount / 5).ToString();
            dollarAmount -= (5 * Convert.ToInt32(fiveNumberLabel.Text));

            oneNumberLabel.Text = dollarAmount.ToString();
        }
    }
}

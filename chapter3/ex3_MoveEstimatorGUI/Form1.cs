// Filename: ex3_MoveEstimatorGUI.csproj
// Written by: Kelley Fischer
// Written on: 01/29/20
// Description: 
//      Chapter 3 - Exercise 3
//      Gets number of hours and number of miles from user, then calculates the totals at
//      the rates $150/hr, $2/mi, and $200 base charge. 
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

namespace ex3_MoveEstimatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double BASE_RATE = 200.00;
            const double HOURLY_RATE = 150.00;
            const double MILEAGE_RATE = 2.00;

            double hours, miles, hoursTotal, milesTotal, totalCharges;

            hours = Convert.ToDouble(hoursTextBox.Text);
            miles = Convert.ToDouble(milesTextBox.Text);

            hoursTotal = hours * HOURLY_RATE;
            milesTotal = miles * MILEAGE_RATE;
            totalCharges = BASE_RATE + hoursTotal + milesTotal;

            hoursChargeLabel.Text = hoursTotal.ToString("C");
            milesChargeLabel.Text = milesTotal.ToString("C");
            totalChargesLabel.Text = totalCharges.ToString("C");

        }
    }
}

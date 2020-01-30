// Filename: ex6_TestsInteractiveGUI.csproj
// Written by: Kelley Fischer
// Written on: 01/29/20
// Description: 
//      Chapter 3 - Exercise 6
//      User enters five test scores and the program calculates the average
//      score.
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

namespace ex6_TestsInteractiveGUI
{
    public partial class TestsInteractiveGUI : Form
    {
        public TestsInteractiveGUI()
        {
            InitializeComponent();
        }

        private void calculateAverage_Click(object sender, EventArgs e)
        {
            double testSum, testAverage;

            testSum = Convert.ToDouble(testOneTextBox.Text);
            testSum += Convert.ToDouble(testTwoTextBox.Text);
            testSum += Convert.ToDouble(testThreeTextBox.Text);
            testSum += Convert.ToDouble(testFourTextBox.Text);
            testSum += Convert.ToDouble(testFiveTextBox.Text);

            testAverage = testSum / 5;

            averageScoreLabel.Text = $"Your average test score is {testAverage.ToString("F2")}.";
        }
    }
}

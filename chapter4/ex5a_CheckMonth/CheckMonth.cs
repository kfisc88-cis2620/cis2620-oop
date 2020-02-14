// Filename: ex5a_CheckMonth.csproj
// Written by: Kelley Fischer
// Written on: 02/11/20
// Description: 
//      Chapter 4 - Exercise 5a
//      Receives input from user for the number of a birth month , then checks
//      to see if the month is valid. If valid, it returns the month.
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

namespace ex5b_CheckMonth
{
    public partial class CheckMonth : Form
    {
        enum Months
        {
            JANUARY = 1, FEBRUARY, MARCH,
            APRIL, MAY, JUNE,
            JULY, AUGUST, SEPTEMBER,
            OCTOBER, NOVEMBER, DECEMBER
        }

        public CheckMonth()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int birthMonth = Convert.ToInt32(birthMonthTextBox.Text);

            switch ((Months)birthMonth)
            {
                case Months.JANUARY:
                    outputLabel.Text = "You entered January.";
                    break;
                case Months.FEBRUARY:
                    outputLabel.Text = "You entered February.";
                    break;
                case Months.MARCH:
                    outputLabel.Text = "You entered March.";
                    break;
                case Months.APRIL:
                    outputLabel.Text = "You entered April.";
                    break;
                case Months.MAY:
                    outputLabel.Text = "You entered May.";
                    break;
                case Months.JUNE:
                    outputLabel.Text = "You entered June.";
                    break;
                case Months.JULY:
                    outputLabel.Text = "You entered July.";
                    break;
                case Months.AUGUST:
                    outputLabel.Text = "You entered August.";
                    break;
                case Months.SEPTEMBER:
                    outputLabel.Text = "You entered September.";
                    break;
                case Months.OCTOBER:
                    outputLabel.Text = "You entered October.";
                    break;
                case Months.NOVEMBER:
                    outputLabel.Text = "You entered November.";
                    break;
                case Months.DECEMBER:
                    outputLabel.Text = "You entered December.";
                    break;
                default:
                    outputLabel.Text = "Invalid month";
                    break;
            }
        }
    }
}

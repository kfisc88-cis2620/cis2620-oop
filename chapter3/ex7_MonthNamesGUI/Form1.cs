using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Filename: ex7_MonthNamesGUI.csproj
// Written by: Kelley Fischer
// Written on: 01/29/20
// Description: 
//      Chapter 3 - Exercise 7
//      Receives input from a user for the number of a month and then
//      returns the name of the month.
// Encountered Issues: None;

namespace ex7_MonthNamesGUI
{
    public partial class Form1 : Form
    {
        enum Month
        {
            JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY,
            AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            int getMonth;

            getMonth = Convert.ToInt32(monthTextBox.Text);

            displayMonthLabel.Text = ($"{(Month)getMonth}");
        }
    }
}

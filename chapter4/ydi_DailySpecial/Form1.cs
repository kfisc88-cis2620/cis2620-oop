// Filename: ydi_DailySpecial.csproj
// Written by: Kelley Fischer
// Written on: 02/11/20
// Description: 
//      Chapter 4 - You Do It: Daily Special
//      Allows user to input a number value a day of the week to see
//      what the daily special at a restaurant is for that day.
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

namespace ydi_DailySpecial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Day
        {
            SUNDAY = 1, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }

        private void SpecialButton_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(dayBox.Text);
            string special;

            switch ((Day)day)
            {
                case Day.SUNDAY:
                    special = "fried chicken";
                    break;
                case Day.MONDAY:
                    special = "Sorry - closed";
                    break;
                case Day.TUESDAY:
                case Day.WEDNESDAY:
                case Day.THURSDAY:
                    special = "meat leaf";
                    break;
                case Day.FRIDAY:
                    special = "fish fry";
                    break;
                case Day.SATURDAY:
                    special = "liver and onions";
                    break;
                default:
                    special = "Invalid day";
                    break;
            }

            outputLabel.Text = "Todays special is " + special;
        }
    }
}

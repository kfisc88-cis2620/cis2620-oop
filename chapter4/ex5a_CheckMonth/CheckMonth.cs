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
        const int MAX_MONTHS = 12, MIN_MONTHS = 1;
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            int birthMonth = Convert.ToInt32(birthMonthTextBox.Text);

            if (birthMonth < MIN_MONTHS || birthMonth > MAX_MONTHS)
                outputLabel.Text = "Not a valid month.";

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
            }
        }
    }
}

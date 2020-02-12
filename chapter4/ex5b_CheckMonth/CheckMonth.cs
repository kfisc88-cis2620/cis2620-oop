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
            int birthDay = Convert.ToInt32(dayTextBox.Text);
            
            //if (birthMonth < MIN_MONTHS || birthMonth > MAX_MONTHS)
            //    outputLabel.Text = "Invalid month.";


            switch ((Months)birthMonth)
            {
                case Months.JANUARY:
                    if (birthDay < 1 || birthDay > 31)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered January {0}.", birthDay);
                    break;

                case Months.FEBRUARY:
                    if (birthDay < 1 || birthDay > 29)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered February {0}.", birthDay);
                    break;

                case Months.MARCH:
                    if (birthDay < 1 || birthDay > 31)
                        outputLabel.Text = "Invalid Day.";
                    else
                            outputLabel.Text = String.Format("You entered March {0}.", birthDay);
                    break;

                case Months.APRIL:
                    if (birthDay < 1 || birthDay > 30)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered April {0}.", birthDay);
                    break;

                case Months.MAY:
                    if (birthDay < 1 || birthDay > 31)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered May {0}.", birthDay);
                    break;

                case Months.JUNE:
                    if (birthDay < 1 || birthDay > 30)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered June {0}.", birthDay);
                    break;

                case Months.JULY:
                    if (birthDay < 1 || birthDay > 31)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered July {0}.", birthDay);
                    break;

                case Months.AUGUST:
                    if (birthDay < 1 || birthDay > 31)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered August {0}.", birthDay);
                    break;

                case Months.SEPTEMBER:
                    if (birthDay < 1 || birthDay > 30)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered September {0}.", birthDay);
                    break;

                case Months.OCTOBER:
                    if (birthDay < 1 || birthDay > 31)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered October {0}.", birthDay);
                    break;

                case Months.NOVEMBER:
                    if (birthDay < 1 || birthDay > 30)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered Novebmer {0}.", birthDay);
                    break;

                case Months.DECEMBER:
                    if (birthDay < 1 || birthDay > 31)
                        outputLabel.Text = "Invalid Day.";
                    else
                        outputLabel.Text = String.Format("You entered December {0}.", birthDay);
                    break;

                default:
                    outputLabel.Text = "Invalid Month";
                    break;
            }
        }
    }
}

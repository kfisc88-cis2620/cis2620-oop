using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch3_exercise1
{
    public partial class InchesToCentimetersGUI : Form
    {
        public InchesToCentimetersGUI()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // One inch is equal to 2.54 centimeters
            const double IN_TO_CM = 2.54;

            double inches,
                centimeters;

            inches = Convert.ToDouble(getInchesTextBox.Text);
            centimeters = inches * IN_TO_CM;
            
            cmConvertLabel.Text = $"{inches}\" = {centimeters.ToString("F2")}cm.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4_MyFlix
{
    public partial class MyFlixForm : Form
    {
        private const double RENTAL_FEE = 1.99;
        public MyFlixForm()
        {
            InitializeComponent();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            var selectedMovies = moviesListBox.SelectedItems;

            confirmLabel.Text = "The movies you selected are:\n";

            foreach (var movie in selectedMovies)
            {
                confirmLabel.Text += movie + "\n";
            }

            confirmLabel.Text += "\nPress 'Submit' to continue.";
            submitButton.Enabled = true;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            for (int x = 0; x < moviesListBox.Items.Count; ++x)
                if (moviesListBox.GetSelected(x))
                    ++count;

            totalLabel.Text = "Total: " + (count * RENTAL_FEE).ToString("C");
        }
    }
}

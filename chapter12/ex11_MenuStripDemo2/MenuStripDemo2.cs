using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11_MenuStripDemo2
{
    public partial class MenuStripDemo2 : Form
    {
        public MenuStripDemo2()
        {
            InitializeComponent();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloLabel.ForeColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloLabel.ForeColor = Color.Green;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloLabel.ForeColor = Color.Red;
        }

        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloLabel.Font = new Font("Courier New", helloLabel.Font.Size, helloLabel.Font.Style);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloLabel.Font = new Font("Times New Roman", helloLabel.Font.Size, helloLabel.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloLabel.Font = new Font(helloLabel.Font.Name, helloLabel.Font.Size, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloLabel.Font = new Font(helloLabel.Font.Name, helloLabel.Font.Size, FontStyle.Italic);
        }
    }
}

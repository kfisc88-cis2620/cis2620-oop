using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void CourierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font("Courier New", userTextBox.Font.Size, userTextBox.Font.Style);
        }

        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font("Times New Roman", userTextBox.Font.Size, userTextBox.Font.Style);
        }

        private void GillSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font("Gill Sans", userTextBox.Font.Size, userTextBox.Font.Style);
        }

        private void CalibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font("Calibri", userTextBox.Font.Size, userTextBox.Font.Style);
        }

        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.ForeColor = Color.Black;
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.ForeColor = Color.Red;
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.ForeColor = Color.Green;
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.ForeColor = Color.Blue;
        }

        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font(userTextBox.Font.Name, userTextBox.Font.Size, FontStyle.Bold);
        }

        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font(userTextBox.Font.Name, userTextBox.Font.Size, FontStyle.Italic);
        }

        private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font(userTextBox.Font.Name, userTextBox.Font.Size, FontStyle.Underline);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Text = "";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TwelvePointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font(userTextBox.Font.Name, 12f, userTextBox.Font.Style);
        }

        private void FourteenPointToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font(userTextBox.Font.Name, 14f, userTextBox.Font.Style);
        }

        private void SixteenPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font(userTextBox.Font.Name, 16f, userTextBox.Font.Style);
        }

        private void EighteenPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTextBox.Font = new Font(userTextBox.Font.Name, 16f, userTextBox.Font.Style);
        }
    }
}

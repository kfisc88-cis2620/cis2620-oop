using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Filename: ex8_PigLatinGUI.csproj
// Written by: Kelley Fischer
// Written on: 01/30/20
// Description: 
//      Chapter 3 - Exercise 8
//      Converts a user input word into the pseduo-langauge Pig Latin.
// Encountered Issues: None;


namespace ex8_PigLatinGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string word, pigLatinWord;

            word = inputTextBox.Text;

            pigLatinWord = word.Substring(1, word.Length - 1) + word.Substring(0, 1).ToLower() + "ay";

            outputLabel.Text = (string)($"The Pig Latin conversion of '{word}' is '{pigLatinWord}'");
        }
    }
}

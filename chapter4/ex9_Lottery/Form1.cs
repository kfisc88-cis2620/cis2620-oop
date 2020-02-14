// Filename: ex9_Lottery.csproj
// Written by: Kelley Fischer
// Written on: 02/13/20
// Description: 
//      Chapter 4 - Exercise 9
//      Generates three random numbers for a 'lottery' and prompts the user to enter three
//      guesses, then compares those guesses to the randomly generated numbers. If there are matches,
//      a prize amount is output.
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

namespace ex9_Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Random ranNumberGenerator = new Random();
            int randNumber1, randNumber2, randNumber3, guessNumber1, guessNumber2, guessNumber3;

            // Generate 3 random numbers
            randNumber1 = ranNumberGenerator.Next(1, 5);
            randNumber2 = ranNumberGenerator.Next(1, 5);
            randNumber3 = ranNumberGenerator.Next(1, 5);

            // Get 3  guesses from user
            guessNumber1 = Convert.ToInt32(guess1TextBox);
            guessNumber2 = Convert.ToInt32(guess2TextBox);
            guessNumber3 = Convert.ToInt32(guess3TextBox);

            switch (guessNumber1)
            {
                case randNumber1:
                    match1Label.Text = "Match!";
                    switch (guessNumber2)
                    {
                        case randNumber2:
                            switch (guessNumber3)
                            {
                                case randNumber3:
                                    prizeOutputLabel.Text = "You win $10,000!!!";
                                    break;
                            }
                    }
            }

        }
    }
}

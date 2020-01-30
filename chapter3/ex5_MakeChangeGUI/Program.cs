// Filename: ex5_MakeChangeGUI.csproj
// Written by: Kelley Fischer
// Written on: 01/29/20
// Description: 
//      Chapter 3 - Exercise 5
//      User enters a whole dollar amount and the program returns the amount of 
//      each bill required to make that amount.
// Encountered Issues: None;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5_MakeChangeGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

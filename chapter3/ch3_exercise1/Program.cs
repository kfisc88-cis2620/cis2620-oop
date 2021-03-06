﻿// Filename: ex1_InchesToCentimetersGUI.csproj
// Written by: Kelley Fischer
// Written on: 01/29/20
// Description: 
//      Chapter 3 - Exercise 1
//      Receives input from a user for number of inches and converts it to centimeters.
// Encountered Issues: None;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch3_exercise1
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
            Application.Run(new InchesToCentimetersGUI());
        }
    }
}

// Filename: DoubleDecimalTest.cs
// Written by: Kelley Fischer
// Written on: 01/22/20
// Description: 
//      Chapter 2 - Exercise 4
//      This program doesn't really do anything, it was just to test the limits of decimal and double.
// Encountered Issues: None;

using System;

namespace ch2_exercise4
{
    class DoubleDecimalTest
    {
        static void Main()
        {
            double value1 = 123456789101112131415161718192.0;
            decimal value2 = 123456789101112131415161718192.0M;
            Console.WriteLine($"{value1} and {value2} are numbers!!");
        }
    }
}

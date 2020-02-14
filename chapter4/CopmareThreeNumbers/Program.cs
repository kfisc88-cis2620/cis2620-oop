// Filename: ydi_CompareThreeNumbers.csproj
// Written by: Kelley Fischer
// Written on: 02/11/20
// Description: 
//      Chapter 4 - You Do It: Compare Three Numbers
//      Prompts the user for numbers, then compares them for equal pairs.
// Encountered Issues: None;

using System;
using static System.Console;

class CompareThreeNumbers
{
    static void Main(string[] args)
    {
        string numberString;
        int num1, num2, num3;

        Write("Enter an integer ");
        numberString = ReadLine();
        num1 = Convert.ToInt32(numberString);

        Write("Enter an integer ");
        numberString = ReadLine();
        num2 = Convert.ToInt32(numberString);

        Write("Enter an integer ");
        numberString = ReadLine();
        num3 = Convert.ToInt32(numberString);

        if (num1 == num2)
            if (num1 == num3)
                WriteLine("All three numbers are equal");
            else
                WriteLine("First two are equal");
        else
        {
            if (num1 == num3)
                WriteLine("First and last are equal");
            else
            {
                if (num2 == num3)
                    WriteLine("Last two are equal");
                else
                    WriteLine("No two numbers are equal");
            }
        }
    }
}
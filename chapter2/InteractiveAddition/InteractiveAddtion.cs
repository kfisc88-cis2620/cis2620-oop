// Filename: InteractiveAddition.cs
// Written by: Kelley Fischer
// Written on: 01/21/20
// Description: Chatper 2: You Do It exercise, pg 88
// Encountered Issues: None;

using System;
using static System.Console;

class InteractiveAddtion
{
    static void Main()
    {
        string name, firstString, secondString;
        int first, second, sum;

        Write("Enter your name... ");
        name = ReadLine();
        Write($"Hello {name}! Enter the first integer... ");
        firstString = ReadLine();
        first = Convert.ToInt32(firstString);
        Write("Enter the second integer... ");
        secondString = ReadLine();
        second = Convert.ToInt32(secondString);
        sum = first + second;
        WriteLine($"{name}, the sum of {first} and {second} is {sum}");
    }
}

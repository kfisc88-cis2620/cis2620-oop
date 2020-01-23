// Filename: DoubleDecimalTest.cs
// Written by: Kelley Fischer
// Written on: 01/22/20
// Description: 
//      Chapter 2 - Exercise 17
//      Prompts the user for an integer from 1 to 8 and returns the corresponding planet.
// Encountered Issues: None;

using System;

namespace ch2_exercise17
{
    class Planets
    {
        enum Planet
        {
            Mercury = 1, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
        }
        static void Main(string[] args)
        {
            int planetNumber;
            string planetAsString;

            Console.WriteLine("Choose an integer from 1 to 8: ");
            planetAsString = Console.ReadLine();
            planetNumber = Convert.ToInt32(planetAsString);

            Console.WriteLine("The planet you chose was {0}.", (Planet)planetNumber);
        }
    }
}

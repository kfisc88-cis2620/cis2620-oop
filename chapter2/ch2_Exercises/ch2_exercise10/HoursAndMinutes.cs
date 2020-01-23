// Filename: HoursAndMinutes.cs
// Written by: Kelley Fischer
// Written on: 01/22/20
// Description: 
//      Chapter 2 - Exercise 10
//      Accepts user input of minutes and converts it to hours with remaining minutes.
// Encountered Issues: None;

using System;

namespace ch2_exercise10
{
    class HoursAndMinutes
    {
        static void Main()
        {
            int minutes, hours, remainingMinutes;

            Console.WriteLine("Enter the number of minutes worked: ");
            string stringMinutes = Console.ReadLine();

            minutes = Convert.ToInt32(stringMinutes);
            hours = minutes / 60;
            remainingMinutes = minutes % 60;

            Console.WriteLine($"Time worked is {hours} hours and {remainingMinutes} minutes.");
        }
    }
}

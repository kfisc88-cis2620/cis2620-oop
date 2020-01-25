using System;
// Filename: PigLatin.cs
// Written by: Kelley Fischer
// Written on: 01/23/20
// Description: 
//      Chapter 2 - Exercise 18
//      Converts a user input word into the pseduo-langauge Pig Latin
// Encountered Issues: None;

namespace ch2_exercise18
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            string word, pigLatinWord;

            Console.WriteLine("Enter a word: ");
            word = Console.ReadLine();

            // Converts the user input word into Pig Latin
            pigLatinWord = word.Substring(1, word.Length-1) + word.Substring(0, 1) + "ay";

            Console.WriteLine("The Pig Latin translation of '{0}' is '{1}'", word, pigLatinWord);
        }
    }
}

// Filename: TestsInteractive.cs
// Written by: Kelley Fischer
// Written on: 01/22/20
// Description: Chapter 2 - Exercise 14
//      Prompts the user for 8 test scores, then returns the average score.
// Encountered Issues: None;

using System;

namespace ch2_exercise14
{
    class TestsInteractive
    {
        static void Main(string[] args)
        {
            int test1, 
                test2, 
                test3, 
                test4, 
                test5, 
                test6, 
                test7, 
                test8;

            float averageTestScore;

            string testScoreString; // Temporarily holds user input to convert to integer

            Console.WriteLine("Welcome! Please enter your first test score: ");
            testScoreString = Console.ReadLine();
            test1 = Convert.ToInt32(testScoreString);
            
            Console.WriteLine("Please enter your next test score: ");
            testScoreString = Console.ReadLine();
            test2 = Convert.ToInt32(testScoreString);
            
            Console.WriteLine("Please enter your next test score: ");
            testScoreString = Console.ReadLine();
            test3 = Convert.ToInt32(testScoreString);
            
            Console.WriteLine("Please enter your next test score: ");
            testScoreString = Console.ReadLine();
            test4 = Convert.ToInt32(testScoreString);
            
            Console.WriteLine("Please enter your next test score: ");
            testScoreString = Console.ReadLine();
            test5 = Convert.ToInt32(testScoreString);
            
            Console.WriteLine("Please enter your next test score: ");
            testScoreString = Console.ReadLine();
            test6 = Convert.ToInt32(testScoreString);
            
            Console.WriteLine("Please enter your next test score: ");
            testScoreString = Console.ReadLine();
            test7 = Convert.ToInt32(testScoreString);
            
            Console.WriteLine("Please enter your next test score: ");
            testScoreString = Console.ReadLine();
            test8 = Convert.ToInt32(testScoreString);

            averageTestScore = (test1 + test2 + test3 + test4 + test5 + test6 + test7 + test8) / 8;

            Console.WriteLine("Your average test score was {0}.", averageTestScore.ToString("F2"));
        }
    }
}

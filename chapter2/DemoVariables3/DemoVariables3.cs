// Filename: DemoVariables3.cs
// Written by: Kelley Fischer
// Written on: 01/21/20
// Description: Chatper 2: You Do It exercise, pg 70
// Encountered Issues: None;

using static System.Console;

class DemoVariables3
{
    static void Main()
    {
        int comparisonValue = 7;
        bool isSixMore = 6 > comparisonValue;
        WriteLine("When comparisonValue is {0}, isSixMore is {1}", comparisonValue, isSixMore);
        comparisonValue = 1;
        isSixMore = 6 > comparisonValue;
        WriteLine("When comparisonValue is {0}, isSixMore is {1}", comparisonValue, isSixMore);
    }
}
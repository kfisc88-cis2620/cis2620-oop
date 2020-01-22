// Filename: DemoVariables2.cs
// Written by: Kelley Fischer
// Written on: 01/21/20
// Description: Chatper 2: You Do It exercise, pg 67
// Encountered Issues: None;

using static System.Console;

class DemoVariables2
{
    static void Main()
    {
        int value1 = 132, value2 = 15, sum, diff, product, quotient, remainder;

        sum = value1 + value2;
        diff = value1 - value2;
        product = value1 * value2;
        quotient = value1 / value2;
        remainder = value1 % value2;

        WriteLine("The sum of {0} and {1} is {2}", value1, value2, sum);
        WriteLine("The difference of {0} and {1} is {2}", value1, value2, diff);
        WriteLine("The product of {0} and {1} is {2}", value1, value2, product);
        WriteLine("The quotient of {0} and {1} is {2}", value1, value2, quotient);
        WriteLine("The remainder of {0} and {1} is {2}", value1, value2, remainder);
    }
}

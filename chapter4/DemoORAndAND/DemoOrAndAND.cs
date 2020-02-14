// Filename: ydi_DemoORAndAND.csproj
// Written by: Kelley Fischer
// Written on: 02/11/20
// Description: 
//      Chapter 4 - You Do It: DemoORAndAND
//      Prompts user for a zone and quantity of packages, then returns whether
//      the delivery is subject to a delivery charge or not.
// Encountered Issues: None;

using System;
using static System.Console;

class DemoOrAndAND
{
    static void Main(string[] args)
    {
        const int ZONE1 = 1, ZONE2 = 2;
        const int LOW_QUANTITY = 10;
        string inputString;
        int quantity;
        int deliveryZone;

        WriteLine("Delivery is free for zone {0} or {1}", ZONE1, ZONE2);
        WriteLine("when the number of boxes is less than {0}", LOW_QUANTITY);
        
        WriteLine("Enter delivery zone ");
        inputString = ReadLine();
        deliveryZone = Convert.ToInt32(inputString);
        
        WriteLine("Enter the number of boxes in the shipment");
        inputString = ReadLine();
        quantity = Convert.ToInt32(inputString);

        if ((deliveryZone == ZONE1 || deliveryZone == ZONE2) && quantity <= LOW_QUANTITY)
            WriteLine("Delivery is free");
        else
            WriteLine("Delivery charge applies");
    }
}

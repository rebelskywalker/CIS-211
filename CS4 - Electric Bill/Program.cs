// *****************************************************************************
// *                             CS4 Electric Bill                             *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Chris Baker                                               *
// *  Chapter      : CS4                                                       *
// *  Assignment   : Lab 5                                                     *
// *  Class Name   : CS4 Electric Bill                                         *
// *  Date Created : 9/29/2015                                                 *
// *  Description  : This class determines a Electric Bill.                    *
// *                                                                           *
// *****************************************************************************

// Use System Namespace
using System;


// Begin CS4 Electric Bill Class

class CS4_Electric_Bill
{

    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method calls the Input KiloWatt Data and Bill    *
    // *                 methods. It displays an end of program message when   *
    // *                 completed.                                            *
    // *************************************************************************

    // Begin Main ()
    static void Main()
{

    // Define Variables: KiloWatts, Rate

    decimal rateDecimal;
    int kiloWattsInteger;

    // Display Title 

    Console.WriteLine("**** Calculate Electric Bill ****");

    // Display Blank Line

    Console.WriteLine();

    // Call Input KiloWatt Data ( Out : KiloWatts, Rate )

    InputKiloWattsData(out kiloWattsInteger, out rateDecimal);



    // Display Blank Line

    Console.WriteLine();
        
    // Display Call Bill ( In : Units, Rate )

    Console.WriteLine("Your Electric Bill is " + Bill(kiloWattsInteger, rateDecimal));

    // Display Blank Line

    Console.WriteLine();

    // Display End of Program Message

        Console.WriteLine("End of Program!");

    // Display Blank Line

    Console.WriteLine();

    // Display Press any key Prompt

    Console.Write("Press any key to continue . . .");

    // Input Press Any Key

    Console.ReadKey();

}   // End Main

    // *************************************************************************
    // *  Method       : Input Kilowatts Data                                  *
    // *  Description  : This method prompts the operator for the amount of    *
    // *                 KiloWatts used and the Rate. The amount of KiloWatts  *
    // *                 used and the Rate are returned as output parameters   *
    // *                 when completed.                                       *
    // *************************************************************************

    // Begin Input Kilowatts Data ( Out: KiloWatts, Rate )
    static void InputKiloWattsData(out int kiloWattsInteger, out decimal rateDecimal)
    {

    // Define Variables: None


    // Display KiloWatts Prompt

    Console.Write("Enter Number of KiloWatts : ");

    // Input KiloWatts 

    int.TryParse(Console.ReadLine(), out kiloWattsInteger);

    // Display Rate Prompt

    Console.Write("Enter Rate Per KiloWatt   : ");

    // Input Rate

    decimal.TryParse(Console.ReadLine(), out rateDecimal);

   } // End Input Kilowatts Data

    // *************************************************************************
    // *  Method       : Bill                                                  *
    // *  Description  : This value returning method receives the KiloWatts    *
    // *                 and Rate as input parameters. The bill is calculated  *
    // *                 by multiplying the KiloWatts used times the Rate. It  *
    // *                 returns the formatted bill as a string value in       *
    // *                 currency format when completed.                       *
    // *************************************************************************

    // Begin Bill ( In: KiloWatts, Rate ) As a String

    static string Bill(int kiloWattsInteger, decimal rateDecimal)
    {

        // Define Variables: Bill, Formatted Bill

        decimal billDecimal;
        string formattedBillString;

        // Calculate BIll = KiloWatts * Rate

        billDecimal = kiloWattsInteger * rateDecimal;

        // Create Formatted Bill

        formattedBillString = billDecimal.ToString("C2");

        // Return Formatted Bill 

        return formattedBillString;

    }// End Bill


}// End CS4 Electric Bill Class


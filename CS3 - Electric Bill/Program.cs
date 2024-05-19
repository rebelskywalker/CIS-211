// *****************************************************************************
// *                             CS3-Electric Bill                             *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Chris Baker                                               *
// *  Chapter      : CS3                                                       *
// *  Assignment   : Lab 4                                                     *
// *  Class Name   : CS3-Electric Bill                                         *
// *  Date Created : 9/21/2015                                                 *
// *  Description  : This class calculates an electric bill based on the       *
// *                 operator's input.                                         *
// *                                                                           *
// *****************************************************************************

// Use System Namespace

using System;

// Begin CS3-Electric Bill Class
class CS3_ElectricBill
{


    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method prompts the operator to enter the         *
    // *                 KiloWatts Usage and Electric Rate. It then takes the  *
    // *                 product of those two integers to display the total    *
    // *                 Electric Bill.                                        *
    // *************************************************************************

    // Begin Main ()

    static void Main()
    {

        // Define Variables: Usage, Rate, Bill

        int usageInteger;
        decimal rateDecimal, billDecimal;


        // Display Title

        Console.WriteLine("Calculate Electric Bill") ;

        // Display Blank Line

        Console.WriteLine() ;

        // Display KiloWatt Usage Prompt

        Console.Write("Enter KiloWatts Usage : ") ;

        // Input KiloWatts Usage

        usageInteger = int.Parse(Console.ReadLine());

        // Display Electric Rate Prompt

        Console.Write("Enter Electric Rate   : ") ;

        // Input Electric Rate

        rateDecimal = decimal.Parse(Console.ReadLine());

        // Display Blank Line

        Console.WriteLine() ;

        // Calculate Electric Bill

        billDecimal = usageInteger * rateDecimal ;

        // Display Electric Bill

        Console.WriteLine("Your Electric Bill is " + billDecimal.ToString("N2"));

        // Display Blank Line

        Console.WriteLine() ;

        // Display Press any key Prompt

        Console.Write("Press any key to continue . . . ") ;

        // Input Press any key

        Console.ReadKey() ;

    }// End Main


}// End CS3-Electric Bill Class


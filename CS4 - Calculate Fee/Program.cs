// *****************************************************************************
// *                             CS4-Calculate Fee                             *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Chris Baker                                               *
// *  Chapter      : CS4                                                       *
// *  Assignment   : Example                                                   *
// *  Class Name   : CS4-Calculate Fee                                         *
// *  Date Created : 9/29/2015                                                 *
// *  Description  : This class determines a student's unit fee.               *
// *                                                                           *
// *****************************************************************************

// Use System Namespace

using System;

// Begin CS4-Calculate Fee Class
class CS4_Calculate_Fee
{

    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method calls the Input Unit Data and Fee         *
    // *                 methods. It displays an end of program message when   *
    // *                 completed.                                            *
    // *************************************************************************

    // Begin Main ()
    static void Main()
    {

        // Define Variables: Units, Rate

        decimal unitsDecimal;
        int rateInteger;

        // Display Title

        Console.WriteLine("**** Calculate Student Fee ****");

        // Display Blank Line

        Console.WriteLine();

        // Call Unit Input Data ( Out: Units, Rate )

        InputUnitData(out unitsDecimal, out rateInteger);

        // Display Blank Line

        Console.WriteLine();

        // Display Call Fee ( In: Units, Rate )

        Console.WriteLine("Your Fee is " + Fee(unitsDecimal, rateInteger) );

        // Display Blank Line

        Console.WriteLine();

        // Display End of Program Message

        Console.WriteLine("End of Program!");


        // Display Blank Line


        Console.WriteLine();

        // Display Press any key Prompt

        Console.Write("Press any key to continue . . .") ;

        // Input Press Any Key

        Console.ReadKey();

    }// End Main

    // *************************************************************************
    // *  Method       : Input Unit Data                                       *
    // *  Description  : This method prompts the operator for the student's    *
    // *                 unirts and unit rate. The units and rate are returned *
    // *                 as output parameters when completed.                  *
    // *************************************************************************

    // Begin Input Unit Data ( Out: Units, Rate )

    static void InputUnitData(out decimal unitsDecimal, out int rateInteger)
    {

        // Define Variables: None
        // Display Units Prompt

        Console.Write("Enter Number of Units : ");

        // Input Units

        decimal.TryParse(Console.ReadLine(), out unitsDecimal);

        // Display Rate Prompt

        Console.Write("Enter Rate Per Unit   : ");

        // Input Rate

        int.TryParse(Console.ReadLine(), out rateInteger);


    }// End Input Unit Data

    // *************************************************************************
    // *  Method       : Fee                                                   *
    // *  Description  : This value returning method receives the units and    *
    // *                 rate as input parameters. The fee is calculated by    *
    // *                 multiplying the units times the unit rate. It returns *
    // *                 the formatted fee as a string value in currency       *
    // *                 format when completed.                                *
    // *************************************************************************

    // Begin Fee ( In: Units, Rate ) As a String

    static string Fee(decimal unitsDecimal, int rateInteger)
    {


        // Define Variables: Fee, Formatted Rate

        decimal feeDecimal;
        string formattedFeeString;

        // Calculate Fee= Units * Rate

        feeDecimal = unitsDecimal * rateInteger;

        // Create Formatted Fee

        formattedFeeString = feeDecimal.ToString("C2");
            
        // Return Formatted Fee 
        return formattedFeeString;

    }// End Fee


}// End CS4-Calculate Fee Class


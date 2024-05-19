// *****************************************************************************
// *                             CS5-Electric Bill                             *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Chris Baker                                               *
// *  Chapter      : CS5                                                       *
// *  Assignment   : Lab6                                                      *
// *  Class Name   : CS5-Electric Bill                                         *
// *  Date Created : 10/6/2015                                                 *
// *  Description  : This class determines an Electric Bill.                   *
// *                                                                           *
// *****************************************************************************

// Use System Namespace
using System;

// Begin CS5-Electric Bill Class
class CS5_Electric_Bill
{

    // Set Residential Rate Constant = .20
    const decimal RESIDENTIAL_RATE_Decimal = .20M;
    // Set Commercial Rate Constant = .15
    const decimal COMMERCIAL_RATE_Decimal = .15M;
    // Set Agricultural Rate Constant = .10
    const decimal AGRICULTURAL_RATE_Decimal = .10M;
    // Set Minimum KiloWatts Constant = 1
    const int MINIMUM_KILOWATTS_Integer = 1;
    // Set Maximum KiloWatts Constant = 10000
    const int MAXIMUM_KILOWATTS_Integer = 10000;


    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method calls the Input Electric Data method. It  *
    // *                 displays an end of program message when completed.    *
    // *************************************************************************

    // Begin Main ()
    static void Main()
    {

    // Define Variables: KiloWatts, Electric Rate, Answer
        int kiloWattsInteger;
        string electricCodeString, answerString;

    // Do 
        do
        {
            // Clear Screen
            Console.Clear();

            // Display Three Title Lines
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("**** Electric Bill Calculator Program ****");
            Console.WriteLine("------------------------------------------");

            // Display Blank Line
            Console.WriteLine();

            // Call Input Electric Data: (Out: KiloWatts, Electric Rate)
            InputElectricData(out kiloWattsInteger, out electricCodeString);

            // Display Blank Line
            Console.WriteLine();

            // Display Call Display Information
            DisplayInformation(kiloWattsInteger, electricCodeString);

            // Display Blank Line
            Console.WriteLine();

            // Do 
            do
            {

                // Display Calculate another Electric Bill Prompt
                Console.Write("Calculate Another Electric Bill (Y/N) ? ");

                // Input Answer
                answerString = Console.ReadLine().ToUpper();

                // While (Answer Not = "Y" And Answer Not = "N")
            } while (answerString != "Y" && answerString != "N");
            // While Answer = "Y"
        } while (answerString == "Y");

    // Clear Screen
        Console.Clear();

    // Display End of Program
        Console.WriteLine("End of Electric Bill Calculator Program!");

    // Display Blank Line
        Console.WriteLine();

    // Display Press any key Prompt
        Console.Write("Press any key to continue . . . ");

    // Input Press Any Key
        Console.ReadKey();


    }// End Main

    // *************************************************************************
    // *  Method       : Input Electric Data                                   *
    // *  Description  : This method inputs the KiloWatts and Electric Rate    *
    // *                 from the keyboard. It must validate the input data    *
    // *                 that it is within the specified limits. It returns    *
    // *                 the KiloWatts and Electric Rate as output parameters  *
    // *                 when completed.                                       *
    // *************************************************************************

    // Begin Input Electric Data ( Out: KiloWatts, Electric Code )
    static void InputElectricData (out int KiloWattsInteger, out string electricCodeString)
    {

    // Define Variables
    // Display KiloWatts Prompt
        Console.Write("Enter KiloWatts (" + MINIMUM_KILOWATTS_Integer +  " to " + MAXIMUM_KILOWATTS_Integer + ") : ") ;

    // Input KiloWatts
    int.TryParse( Console.ReadLine(), out KiloWattsInteger);

    // Do  While( KiloWatts < Minimum KiloWatts constant Or KiloWatts > Maximum KiloWatts)
        while (KiloWattsInteger < MINIMUM_KILOWATTS_Integer || KiloWattsInteger > MAXIMUM_KILOWATTS_Integer)
        {
    // Display KiloWatts Error
            Console.Write("Units Error - Try Again      : ") ;

    // Input Another KiloWatts
            int.TryParse(Console.ReadLine(), out KiloWattsInteger);
        }// End Do 

    // Display Blank Line
        Console.WriteLine();

    // Display Electric Rate Codes (3 lines)
        Console.WriteLine("Electric Rate Codes: ");
        Console.WriteLine("R - Residential Rate");
        Console.WriteLine("C - Commercial Rate");
        Console.WriteLine("A - Agriculture Rate");

    // Display Blank Line
        Console.WriteLine();

    // Display Electric Rate Prompt
        Console.Write("Enter Rate Code (R,C,A)      : ");

    // Input Electric Rate
        electricCodeString = Console.ReadLine().ToUpper();

    // Do  (While Electric Rate Code Not = "R" And Not = "C" And Not = "A")
        while (electricCodeString != "R" && electricCodeString != "N" && electricCodeString != "F")
        {
            // Display Electric Rate Error Message
            Console.Write("Rate Code Error - Try Again  : ");

    // Input Another Electric Rate
            electricCodeString = Console.ReadLine().ToUpper();

        }// End Do 

    }// End Input Electric Data

    // *************************************************************************
    // *  Method       : Display Information                                   *
    // *  Description  : This module displays the KiloWatt Usage, Rate, and    *
    // *                 Electric Bill. The bill is calculated by multiplying  *
    // *                 the KiloWatt Usage by the KiloWatt Rate. The KiloWatt *
    // *                 Rate is obtained by calling the Get Electric Rate     *
    // *                 module. It receives the KiloWatts and Rate Code as    *
    // *                 Input arguments.                                      *
    // *************************************************************************

    // Begin Display Information ( In: KiloWatts, Rate Code )
    static void DisplayInformation(int kiloWattsInteger, string rateCodeString)
    {

        // Define Variables: Electric Bill
        decimal electricBillDecimal;
        
        //Display Units
        Console.WriteLine("Your KiloWatt Usage Is " + kiloWattsInteger);

        // Display Call Get KiloWatt Rate (In: Rate Code)
        Console.WriteLine("Your Rate Per KiloWatt is " + GetElectricRate(rateCodeString).ToString("C2"));

        // Display Blank Line
        Console.WriteLine();

        // Calculate Bill = KiloWatts Usage times Call Get KiloWatts Rate (In: Rate Code)
        electricBillDecimal = kiloWattsInteger * GetElectricRate(rateCodeString);

        // Display Electric Bill
        Console.WriteLine("Your Electric Bill is " + electricBillDecimal.ToString("C2"));

    }// End Display Information

    // *************************************************************************
    // *  Method       : Get Electric Rate                                     *
    // *  Description  : This value returning method determines a KiloWatt     *
    // *                 Rate based upon the rate code. The rate is determined *
    // *                 "R" uses Residential Rate, "C" uses Commercial Rate,  *
    // *                 and "A" uses Agricultural Rate. These rates are       *
    // *                 defiend as class constants. It receives the rate code *
    // *                 as an input parameter and returns the rate as a       *
    // *                 decimal value when completed.                         *
    // *************************************************************************

    // Begin Get Electric Rate ( In: Rate Code ) As a Decimal Number
    static decimal GetElectricRate(string rateCodeString)
    {

        // Define Variables: Rate
        decimal rateDecimal;

        // IF Rate Code = "R"
        if (rateCodeString == "R")

            // Rate = Residential Rate constant
            rateDecimal = RESIDENTIAL_RATE_Decimal;

        // Else IF Rate Code = "C"
        else if (rateCodeString == "C")

            // Rate = Commercial Rate constant
            rateDecimal = COMMERCIAL_RATE_Decimal;

        // Else
        else

            // Rate = Agricultural Rate constant
            rateDecimal = AGRICULTURAL_RATE_Decimal;

        // End IF

        // Return Rate 
        return rateDecimal;

    }// End Get Electric Rate



}// End CS5-Electric Bill Class


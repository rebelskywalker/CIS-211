// *****************************************************************************
// *                              CS5-Student Fee                              *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Chris Baker                                               *
// *  Chapter      : CS5                                                       *
// *  Assignment   : Example                                                   *
// *  Class Name   : CS5-Student Fee                                           *
// *  Date Created : 10/6/2015                                                 *
// *  Description  : This class determines a student's enrollment fee.         *
// *                                                                           *
// *****************************************************************************

// Use System Namespace

using System;

// Begin CS5-Student Fee Class

class CS5_Student_Fee
{

    // Set Enrollment Rate constant = $20

    const int ENROLLMENT_RATE_Integer = 20;

    // Set Non-Resident Rate constant = $162

    const int NON_RESIDENT_RATE_Integer = 162;

    // Set Non-US Citizen Rate constant = $182

    const int NON_US_CITIZEN_RATE_Integer = 182;

    // Set Maximum Units constant = 0.5

    const decimal MINIMUM_UNITS_Decimal = 0.5M;

    // Set Maximum Units constant = 24

    const decimal MAXIMUM_UNITS_Decimal = 24.0M;


    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method calls the Input Student Data and Display  *
    // *                 Information methods. It displays an end of program    *
    // *                 message when completed.                               *
    // *************************************************************************

    // Begin Main ()

    static void Main()
    {



        // Define Variables: Units, Resident Code, Answer

        decimal unitsDecimal;
        string residentCodeString, answerString;

        // Do 
        do
        {
            // Clear Screen

            Console.Clear();

            // Display Threee Title Lines

            Console.WriteLine("-------------------------------");
            Console.WriteLine("****  Student Fee Program  ****");
            Console.WriteLine("-------------------------------");

            // Display Blank Line

            Console.WriteLine();

            // Call Input Student Data: (Out: Units, Resident Code)

            InputStudentData(out unitsDecimal, out residentCodeString);

            // Display Blank Line

            Console.WriteLine();

            // Display Call Display Information

            Console.WriteLine("Call Display Information");

            // Display Blank Line

            Console.WriteLine();

            // Do 
            do
            {
                // Display Enter More Fee Data Prompt

                Console.Write("Enter more fee data (Y/N) ? ");

                // Input Answer

                answerString = Console.ReadLine().ToUpper();

                // While (Answer Not = "Y" And Answer Not = "N")
            
            } while (answerString != "Y" && answerString != "N");


            // While Answer = "Y"
        } while (answerString == "Y");

        // Clear Screen

        Console.Clear();

        // Display End of Program message
        Console.WriteLine("End of Student Fee Program!");

        // Display Blank Line

        Console.WriteLine();

        // Display Press any key Prompt

        Console.Write("Press any key to continue . . . ");

        // Input Press Any Key

        Console.ReadKey();

    }// End Main

    // *************************************************************************
    // *  Method       : Input Student Data                                    *
    // *  Description  : This method inputs the units and resident code from   *
    // *                 the keyboard. It must validate the input data that it *
    // *                 is within the specified limits. It returns the units  *
    // *                 and resident code as output parameters when           *
    // *                 completed.                                            *
    // *************************************************************************

    // Begin Input Student Data ( Out: Units, Resident Code )

    static void InputStudentData(out decimal unitsDecimal, out string residentCodeString)
    {

        // Define Variables: None
        // Display Units Prompt

        Console.Write("Enter Units (" + MINIMUM_UNITS_Decimal + " to " + MAXIMUM_UNITS_Decimal + ") : ");

        // Input Units

        decimal.TryParse(Console.ReadLine(), out unitsDecimal);

        // Do  While ( Units < Minimum Units constant Or Units > Maximum Units Constant )

        while (unitsDecimal < MINIMUM_UNITS_Decimal || unitsDecimal > MAXIMUM_UNITS_Decimal)
        {



            // Display Units Error Message

            Console.Write("Units Error - Try Again   : ");

            // Input Another Units

            decimal.TryParse(Console.ReadLine(), out unitsDecimal);

        }// End Do 

        // Display Blank Line

        Console.WriteLine();

        // Display Residency Codes (4 lines)

        Console.WriteLine("Resident Codes:");
        Console.WriteLine("R - Resident of California");
        Console.WriteLine("N - Non-California Resident");
        Console.WriteLine("F - Non-US Citizen");

        // Display Blank
        Console.WriteLine();
        


        // Display Resident Code prompt

        Console.Write("Enter Residency (R,N,F)   : ");

        // Input Resident Code

        residentCodeString = Console.ReadLine().ToUpper();

        // Do  ( While Resident Code Not = "R" And Not = "N" And Not = "F" )

        while (residentCodeString != "R" && residentCodeString != "N" && residentCodeString != "F")
        {

            // Display Resident Code Error Message

            Console.Write("Code Error - Try Again    : ");

            // Input Another Resident Code

            residentCodeString = Console.ReadLine().ToUpper(); 

        }// End Do 

    }// End Input Student Data


}// End CS5-Student Fee Class


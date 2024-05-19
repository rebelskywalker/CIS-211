// *****************************************************************************
// *                                CS1-Welcome                                *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Chris Baker                                               *
// *  Chapter      : CS1                                                       *
// *  Assignment   : Example                                                   *
// *  Class Name   : CS1-Welcome                                               *
// *  Date Created : 9/14/2015                                                 *
// *  Description  : This class displays a welcome message.                    *
// *                                                                           *
// *****************************************************************************

// Use System Namespace

using System;

// Begin CS1-Welcome Class

class CS1_Welcome
{



    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method prompts the operator for their last name  *
    // *                 and first name. It then displays their first and last *
    // *                 name followed by a welcome message.                   *
    // *************************************************************************

    // Begin Main ()

    static void Main()
    {
        // Define Variables: Last Name, First Name

        string lastNameString, firstNameString;

        // Display Title
        Console.WriteLine("**** Welcome Program ****");

        // Display Blank Line
        Console.WriteLine();

        // Display Last Name Prompt
        Console.Write("Enter Last Name : ");

        // Input Last Name
        lastNameString = Console.ReadLine();

        // Display First Name Prompt
        Console.Write("Enter First Name: ");

        // Input First Name
        firstNameString = Console.ReadLine();

        // Display Blank Line
        Console.WriteLine();

        // Display First Name and Last Name
        Console.WriteLine(firstNameString + " " + lastNameString);

        // Display Welcome Message
        Console.WriteLine("Welcome to Visual C# Programming!");

        // Display Blank Line
        Console.WriteLine();

        // Display Press any key Prompt
        Console.Write("Press any key to continue...");

        // Input Press Any Key
        Console.ReadKey();

    }// End Main


}// End CS1-Welcome Class


// *****************************************************************************
// *                           CS1- Electric Customer                          *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Chris  Baker                                              *
// *  Chapter      : CS1                                                       *
// *  Assignment   : CS1-1                                                     *
// *  Class Name   : CS1- Electric Customer                                    *
// *  Date Created : 9/14/2015                                                 *
// *  Description  : This class displays customer information including the    *
// *                 customer number and name.                                 *
// *                                                                           *
// *****************************************************************************

// Use System Namespace
using System;
// Begin CS1- Electric Customer Class
class CS1_Electric_Customer
{ 

// *************************************************************************
// *  Method       : Main                                                  *
// *  Description  : This method prompts the operator to enter their       *
// *                 customer number, last name, and first name. It then   *
// *                 displays their customer number and name.              *
// *************************************************************************

// Begin Main ()
    static void Main()
    {

        // Define Variables: Number, Last Name, First Name
        string numberString, lastNameString, firstNameString;

        // Display Title
        Console.WriteLine("Electric Customer Information");

        // Display Blank Line
        Console.WriteLine();

        // Display Number Prompt
        Console.Write("Enter Number    : ");

        // Input Number
        numberString = Console.ReadLine();

        // Display Last Name Prompt
        Console.Write("Enter Last Name : ");

        // Input Last Name
        lastNameString = Console.ReadLine();

        // Display First Name Prompt
        Console.Write("Enter First Name: ");

        // Input First Name
        firstNameString = Console.ReadLine();

        // Display Blank
        Console.WriteLine();

        // Display Number
        Console.WriteLine(numberString);

        // Display First Name and Last Name
        Console.WriteLine(firstNameString + " " + lastNameString);

        // Display Blank
        Console.WriteLine();


        // Display Press Any Key Prompt
        Console.Write("Press any key to continue . . .");


        // Input Any Key
        Console.ReadKey();

    }// End Main


}// End CS1- Electric Customer Class


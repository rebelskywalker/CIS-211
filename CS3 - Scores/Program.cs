// *****************************************************************************
// *                                 CS3-Scores                                *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Chris Baker                                               *
// *  Chapter      : CS3                                                       *
// *  Assignment   : Example                                                   *
// *  Class Name   : CS3-Scores                                                *
// *  Date Created : 9/21/2015                                                 *
// *  Description  : This class calculates the total and average of three exam *
// *                 scores.                                                   *
// *                                                                           *
// *****************************************************************************

// Use System Namespace
using System;

// Begin CS3-Scores Class
class CS3_Scores
{

    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method prompts the operator to enter three exam  *
    // *                 scores from the keyboard. It then calculates and      *
    // *                 displays the total and average.                       *
    // *************************************************************************

    // Begin Main ()

    static void Main()
    {

        // Define Variables: Exam1, Exam2, Exam3, Total, Average

        int exam1Integer, exam2Integer, exam3Integer, totalInteger;
        decimal averageDecimal ; 

        // Display Title

        Console.WriteLine("Calculate Exam Total and Average") ;

        // Display Blank Line

        Console.WriteLine() ;

        // Display Exam1 Prompt

        Console.Write("Enter Exam 1 : ") ;

        // Input Exam1

        exam1Integer = int.Parse(Console.ReadLine() ) ;
        
        // Display Exam2 Prompt

        Console.Write("Enter Exam 2 : ") ;

        // Input Exam2

        exam2Integer = int.Parse(Console.ReadLine()) ;
          
        // Display Exam3 Prompt

        Console.Write("Enter Exam 3 : ") ;

        // Input Exam3

        exam3Integer = int.Parse(Console.ReadLine()) ;

        // Calculate Total = Exam1 + Exam2 + Exam3

        totalInteger = exam1Integer + exam2Integer + exam3Integer ;

        // Calculate Average = Total / 3

        averageDecimal = (decimal)totalInteger / 3M ;

        // Display Blank Line

        Console.WriteLine() ;

        // Display Total

        Console.WriteLine("Your Total is " + totalInteger + " points") ;

        // Display Average

        Console.WriteLine("Your Average is " +
                            averageDecimal.ToString("N2")) ;

        // Display Blank Line

        Console.WriteLine();


        // Display Press any key Prompt

        Console.Write("Press any key to continue . . . ") ;

        // Input Press Any Key

        Console.ReadKey() ;

    }// End Main


} // End CS3-Scores Class


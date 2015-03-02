/******************************************************************************
 * Bellevue Class: PROG 110
 *     Instructor: Robert Main
 *           Term: TTTTT yyyy  (Ex.: Fall 2014)
 *
 * Solution/Project Name: **Name you specify for your Visual Studio Solution**
 *
 *     Class: ApplicationEntry
 * File Name: **Name you give to this C# source code file**
 *
 * This file defines the entry point method, Main(), for a C# Console
 * application. When the executable file is selected for execution, the OS
 * will transfer execution to the first line of code in method Main(). Other
 * methods called from Main() may be defined here as well.
 *
 * Programmer: **Your Name Here**
 * 
 * Assigned Project Number: **See Syllabus, for example: 2A**
 *
 * 
 * Revision     Date                        Release Comment
 * --------  ----------  ------------------------------------------------------
 *   1.0     MM/DD/YYYY  Initial Release
 *   x.x     MM/DD/YYYY  **Describe, in 1 line, what change(s) was/were made**
 *
 * 
 * Program Inputs
 * --------------
 *  Device                              Description
 * --------  ------------------------------------------------------------------
 * Keyboard  ** Describe any inputs from the User; otherwise, None **
 *
 * 
 * Program Outputs
 * ---------------
 *  Device                            Description
 * --------  ------------------------------------------------------------------
 * Monitor   ** Describe any Console display; otherwise, None **
 *
 * 
 * File Methods
 * ------------
 *     Name                             Description
 * ------------  --------------------------------------------------------------
 * Main          Program entry point method
 * **** Add name and description of any other methods defined in this file ****
 *
 ******************************************************************************
 */
// Namespaces used by the file
using System;

class ApplicationEntry
{
    /***************************************************************************
     * Method: Main()
     * 
     * Method Description
     * ------------------
     * ** For method Main(), describe the application program from the client's
     * ** perspective, which includes any User inputs required and expected
     * ** Console output, and any other pertinent information about the program.
     * ** For other Class methods, describe the functionality of the method.
     * ** This WILL take several lines for a satisfactory description!
     * 
     * Pre-Conditions
     * --------------
     * ** Describe any assumptions made by the method; otherwise specify: None **
     *
     * Method Arguments
     * ----------------
     *   Type        Name                        Description
     * --------  -------------  ------------------------------------------------
     *                        *** No Arguments supplied ***
     * 
     * Return Value
     * ------------
     *   Type                              Description
     * --------  ---------------------------------------------------------------
     * void      No value RETurned by the method
     *
     ***************************************************************************
     */
    static void Main()
    {
        char[] size = { 'S', 'M', 'L', 'X'};
        double[] cost = { 6.99, 8.99, 12.50, 15.00};
        double doubleCost, doubleDiscount=0, finaltotal;
        const int max = 8, min = 1;
        char pizza;
       
        int index = 0, number;
        bool found = false, found2 = false, verification;
        
        Console.WriteLine("     MENU" + "\n---------------" + "\nSIZE" + "     PRICE" + "\n S       $6.99" + "\n M       $8.99" + "\n L       $12.50"+"\n X       $15.00");

        do 
        {

            Console.WriteLine("What size pizza would you like? (S, M, L, or X");
            verification = Char.TryParse(Console.ReadLine(), out pizza);
            pizza = Char.ToUpper(pizza);
        }
        while (verification == false || (pizza != 'S' && pizza != 'M' && pizza != 'L' && pizza != 'X'));

        do
        {
            Console.WriteLine("How many pizzas would you like? (max 8)");
            verification = int.TryParse(Console.ReadLine(), out number);
           
        }
        while (verification == false || (number < min || number > max));

        switch (number)
        { 

            case 0:
                
            Console.WriteLine("sorry you did not order enough pizzas for a discount.");
            break;
        
            case 2:
        
            Console.WriteLine( "You've recieved a 10 percent discount for ordering 2 pizzas!");
            doubleDiscount = .10;
            break;
        
        
            case 3:

            Console.WriteLine("You've recieved a 15 percent discount for ordering" + number + "pizzas");
            doubleDiscount = .15;
            break;

           
            case 4:

            Console.WriteLine("You've recieved a 15 percent discount for ordering" + number + "pizzas");
            doubleDiscount = .15;
            break;

            default:
        
            Console.WriteLine( "You've recieved a 20 percent discount for ordering 5 or more!");
            doubleDiscount = .20;
            break;

       
        }

        while (!found && index < size.Length)
        {
            if (pizza == size[index])
                found = true;
            else
                ++index;
        }


        while (!found2 && index < cost.Length)
        {
            if (pizza == size[index])
                found2 = true;
            else
                ++index;
        }

        if (found && found2)
        {
            doubleCost = cost[index] * number;
            Console.WriteLine("The cost before discount is {0}.",
                    doubleCost.ToString("C2"));

            finaltotal = doubleCost * doubleDiscount;
            finaltotal = finaltotal + doubleCost;
            Console.WriteLine("The cost final total is {0}.", finaltotal );
        }

        // This stops the Visual Studio debug window from closing at the
        // end of program execution.
        Console.Write("\nPress any key to exit program: ");
        Console.ReadKey();

    }   // End Class Method: Main()

}   // End Class Definition: ApplicationEntry
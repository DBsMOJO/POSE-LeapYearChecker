/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 12.11.2023
 *--------------------------------------------------------------
 * Description:
 * Checks the given year to see if it was a leap year
 *--------------------------------------------------------------
*/

using System;

namespace LeapYearChecker
{
    public class Program
    {
        public static void Main()
        {
            int givenYear;

            // Enty
            Console.WriteLine("Leap Year Checker!");

            do
            {
                // Input
                Console.Write("Enter year: ");
                givenYear = Convert.ToInt32(Console.ReadLine());

                // Process
                if (givenYear > 0)
                {
                    if (givenYear % 4 == 0)
                    {
                        Console.WriteLine("Year {0} is a leap year!", givenYear);
                    }
                    else
                        Console.WriteLine("Year {0} is not a leap year.", givenYear);
                }
                else if (givenYear < 0)
                {
                    Console.WriteLine("Invalid input...");
                }
            } while (givenYear != 0);
        }
    }
}

/// Chapter No. 1		Exercise No. 2
/// File Name: DrawWizard
/// @author: Evan Sinclair
/// Date:  August 24, 2020
///
/// Problem Statement: Draw a picture using "*"
/// 
/// 
/// Overall Plan:
/// 1)Create lines using asterisk and whitespace with method Console.WriteLine()
/// 2)Adjust lines until output looks like a Wizard
using System;

namespace Part2
{
    class DrawWizard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                     ***                    ");
            Console.WriteLine("                    ****                    ");
            Console.WriteLine("                  *****                     ");
            Console.WriteLine("                 *******                    ");
            Console.WriteLine("                 *****               *      ");
            Console.WriteLine("                 ********           **      ");
            Console.WriteLine("       *        ***********        ***      ");
            Console.WriteLine("      ***     *************        ***      ");
            Console.WriteLine("     **********************************     ");
            Console.WriteLine("    *********************************       ");
            Console.WriteLine("                *   *  *   *                ");
            Console.WriteLine("                *         *                 ");
            Console.WriteLine("                 **  **  *                  ");
            Console.WriteLine("                   ******                   ");
            Console.WriteLine("                    *****                   ");
            Console.WriteLine("                     ***                    ");
            Console.WriteLine("                     **                     ");
            Console.WriteLine("                     *                      ");
        }
    }
}

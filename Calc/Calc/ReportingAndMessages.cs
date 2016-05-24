using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ReportingAndMessages
    {
        public static void ShowCorrectFormatMessage()
        {
            Console.WriteLine("Enter the expression in the following format: 2 + 3");
        }

        public static void ShowIncorrectInputMessage()
        {
            Console.WriteLine("\nYou have entered the expression in incorrect format. Correct format is: 2 + 3");
        }

        public static void ShowResult(double result, bool success)
        {

            if (success)
                Console.WriteLine("\nResult: " + result);
            else
                Console.WriteLine("\nIncorrect operation");
        }

        public static void ShowContinueExitMessage()
        {
            Console.WriteLine("\nTo continue press any key. To exit press 0\n");
        }
    }
}

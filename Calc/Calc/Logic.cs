using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Logic
    {
        static double firstNum, secondNum;
        static string sign;
        static bool correctInput;

        public static void InitialiseMembers()
        {
            do
            {
                correctInput = ParseInput(out firstNum, out sign, out secondNum);
                if (!(sign == "+" || sign == "-" || sign == "*" || sign == "/"))
                    correctInput = false;

            }
            while (!correctInput);
        }

        public static bool CalculatorOperations(out double result)
        {
            ReportingAndMessages.ShowCorrectFormatMessage();
            InitialiseMembers();

            result = 0;
            bool correctOperation = true;

            if (sign == "+")
                result = firstNum + secondNum;

            if (sign == "-")
                result = firstNum - secondNum;

            if (sign == "*")
                result = firstNum * secondNum;

            if (sign == "/")
            {
                result = firstNum / secondNum;
                if (secondNum == 0)
                {
                    correctOperation = false;
                }
            }
            return correctOperation;
        }

        public static bool ParseInput(out double firstNum, out string sign, out double secondNum)
        {
            string expression = Console.ReadLine();
            var expParts = expression.Split(' ');

            firstNum = 0;
            secondNum = 0;
            sign = null;

            if (expParts.Length == 3)
            {
                if (Double.TryParse(expParts[0], out firstNum) == true && Double.TryParse(expParts[2], out secondNum) == true)
                {
                    sign = expParts[1];
                    return true;
                }
                else
                {
                    ReportingAndMessages.ShowIncorrectInputMessage();
                    return false;
                }
            }
            else
            {
                ReportingAndMessages.ShowIncorrectInputMessage();
                return false;
            }
        }

        public static bool Continue()
        {
            ReportingAndMessages.ShowContinueExitMessage();
            var exit = Console.ReadKey();
            if (exit.Modifiers.ToString() == "0")
                return false;
            else
                return true;
        }
    }
}


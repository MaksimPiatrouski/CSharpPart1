using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    class Calculator
    {
        static void Main(string[] args)
        {
            double result;
            bool continueCmd = false;
            do
            {
                bool success = Logic.CalculatorOperations(out result);
                ReportingAndMessages.ShowResult(result, success);
                continueCmd = Logic.Continue();
            }
            while (continueCmd);
        }
    }
}

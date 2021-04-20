using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ConsoleApp
{
    class OptionVerifier
    {
        public readonly string AdditionOption = "1";
        public readonly string SubtractionOption = "2";
        public readonly string MultiplicationOption = "3";
        public readonly string DivisionOption = "4";
        public readonly string ShowPreviousOption = "5";
        public readonly string ExitOption = "6";


        public bool IsExitOption(string option)
        {
            return option == ExitOption;
        }

        public bool IsShowPreviousOption(string option)
        {
            return option == ShowPreviousOption;
        }

        public bool IsOption(string option)
        {
            return option == AdditionOption || option == SubtractionOption || option == MultiplicationOption || option == DivisionOption || option == ShowPreviousOption || option == ExitOption;
        }
    }
}

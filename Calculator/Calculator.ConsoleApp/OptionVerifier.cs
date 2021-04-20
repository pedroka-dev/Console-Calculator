using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ConsoleApp
{
    static class OptionVerifier
    {
        public static bool IsExitOption(string option)
        {
            return option == "6";
        }

        public static bool IsPreviousOperationOption(string option)
        {
            return option == "5";
        }

        public static bool IsOption(string option)
        {
            return option == "1" || option == "2" || option == "3" || option == "4" || option == "5" || option == "6";
        }
    }
}

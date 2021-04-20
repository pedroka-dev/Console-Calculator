using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ConsoleApp
{
    static class TextDisplayer
    {
        public static void ShowInitializationText()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=-=-=-=-=- Calculator -=-=-=-=-=");
            Console.WriteLine("Enter the type of the desired operation:");
            Console.WriteLine("  1 - Addition");
            Console.WriteLine("  2 - Subtraction");
            Console.WriteLine("  3 - Multiplication");
            Console.WriteLine("  4 - Division");
            Console.WriteLine("  5 - Show previous operations");
            Console.WriteLine("  6 - Exit");
            Console.WriteLine("=-=-=-=-=- =-=-=-=-=-= -=-=-=-=-=");
        }

        public static void ShowErrorText(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadLine();
        }

        public static void ShowResultText(Operation operation)
        {
            Console.WriteLine("Result:" + operation.Result);
            Console.WriteLine("=-=-=-=-=- =-=-=-=-=-= -=-=-=-=-=");
            Console.WriteLine(operation.AttributesToString());
            Console.ReadLine();
        }
    }
}

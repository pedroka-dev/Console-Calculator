using System;
using System.Collections.Generic;

namespace Calculator.ConsoleApp
{
    class Program
    {
        private static void ShowInitializationText()
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

        private static void ShowErrorText(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadLine();
        }

        private static void ShowResultText(double result, string operation)
        {
            Console.WriteLine("Result:" + result);
            Console.WriteLine("=-=-=-=-=- =-=-=-=-=-= -=-=-=-=-=");
            Console.WriteLine(operation);
            Console.ReadLine();
        }

        private static bool IsExitOption(string option)
        {
            return option == "6";
        }

        private static bool IsPreviousOperationOption(string option)
        {
            return option == "5";
        }

        private static bool IsOption(string option)
        {
            return option == "1" || option == "2" || option == "3" || option == "4" || option == "5" || option == "6";
        }

        static void Main(string[] args)
        {
            List<string> operationList = new List<string>();

            while (true)
            {
                ShowInitializationText();

                string userOption = Console.ReadLine();

                if (!IsOption(userOption))
                {
                    ShowErrorText("Error: Invalid operation type! Try again with a valid option.");
                    continue;
                }

                if (IsPreviousOperationOption(userOption))
                {
                    Console.WriteLine("=-=-=-=-=- OPERATIONS -=-=-=-=-=");
                    foreach (string operation in operationList)
                    {
                        Console.WriteLine(operation);
                    }
                    Console.ReadLine();
                    continue;
                }
                else if (IsExitOption(userOption))
                {
                    break;
                }

                Console.WriteLine("Enter the first number:");
                string numberA = Console.ReadLine();

                Console.WriteLine("Enter the second number:");
                string numberB = Console.ReadLine();

                double operationResult = 0;
                string operationSymbol = "";

                try
                {
                    switch (userOption)
                    {
                        case "1":
                            operationResult = double.Parse(numberA) + double.Parse(numberB);
                            operationSymbol = "+";
                            break;

                        case "2":
                            operationResult = double.Parse(numberA) - double.Parse(numberB);
                            operationSymbol = "-";
                            break;

                        case "3":
                            operationResult = double.Parse(numberA) * double.Parse(numberB);
                            operationSymbol = "*";
                            break;

                        case "4":
                            if (numberB == "0")
                                throw new DivideByZeroException();

                            operationResult = double.Parse(numberA) / double.Parse(numberB);
                            operationSymbol = "/";
                            break;

                        default:

                            break;
                    }
                }
                catch (FormatException)
                {
                    ShowErrorText("Error: Invalid format value. Try again with a valid double value.");
                    continue;
                }

                catch (DivideByZeroException)
                {

                    ShowErrorText("Error: Division by Zero is not allowed. Perform the division with any value other than 0.");
                    continue;
                }

                string sucessfullOperation = $"{numberA} {operationSymbol} {numberB} = {operationResult}";
                operationList.Add(sucessfullOperation);

                ShowResultText(operationResult, sucessfullOperation);
                continue;
            }
        }
    }
}
